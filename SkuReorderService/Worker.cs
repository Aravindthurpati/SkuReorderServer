using SkuReorderService.Configuration;
using SkuReorderService.DTO;
using SkuReorderService.IRepositary;
using SkuReorderService.Models;
using SkuReorderService.Services;
using System;
using System.Runtime;

namespace SkuReorderService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        public readonly MAIWMSContext _context;
        public readonly ISkuRepositary _skurepositary;
        private readonly IMailService _mail;
        private readonly MailSettingss _settings;


        public Worker(ILogger<Worker> logger, MAIWMSContext context, ISkuRepositary skurepositary, IMailService mail, MailSettingss settings)
        {
            _logger = logger;
            _context = context;
            _skurepositary = skurepositary;
            _mail = mail;
            _settings = settings;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                    //DateTime currentTime = DateTime.Now;
                    //TimeSpan desiredTime = new TimeSpan(9,49, 0); // Desired time is 9:00 AM

                    //if (currentTime.Hour == desiredTime.Hours && currentTime.Minute == desiredTime.Minutes) /*&& currentTime.DayOfWeek == DayOfWeek.Monday)*/
                    DateTime currentTime = DateTime.Now; // Get the current time in the system's time zone
                    TimeSpan desiredTime = new TimeSpan(10, 52, 0); // Desired time is 9:00 AM

                    TimeZoneInfo systemTimeZone = TimeZoneInfo.Local; // Get the system's time zone
                    DateTime currentTimeInUtc = TimeZoneInfo.ConvertTimeToUtc(currentTime, systemTimeZone); // Convert the system time to UTC

                    DateTime desiredDateTimeInUtc = DateTime.UtcNow.Date.Add(desiredTime); // Create a DateTime object with today's date and the desired time in UTC

                    if (currentTimeInUtc.Hour == desiredDateTimeInUtc.Hour && currentTimeInUtc.Minute == desiredDateTimeInUtc.Minute)

                    {
                        List<ClientDTO> clientdata = _skurepositary.clientList();

                        foreach (var client in clientdata)
                        {
                            SkuMailDTO maildata = new SkuMailDTO();
                            maildata.client = client.Clientname;
                            maildata.Email = client.Reordertoemail == null ? (new List<string>()) : client.Reordertoemail.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                            maildata.BccEmail = client.Reorderbccemail == null ? (new List<string>()) : client.Reorderbccemail.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                            maildata.client = client.Clientname;
                            maildata.currentdate = DateTime.Now.ToShortDateString();
                            if (client.Photo != null)
                            {
                                byte[] logoImageBytes = client.Photo.ToArray();
                                maildata.logo = "data:image/png;base64," + Convert.ToBase64String(logoImageBytes);
                            }
                            else
                            {
                                maildata.logo = "";
                            }


                            List<SkuDTO> skus = new List<SkuDTO>();
                            var skudata = _skurepositary.getSkuData(client.Uniqueid);
                            foreach (var item in skudata)
                            {
                                var totalqty = _skurepositary.getInventoryqty(item.SkuId);
                                if (item.Reorderqty > totalqty)
                                {
                                    item.totalqty = totalqty;
                                    skus.Add(item);
                                }
                            }
                            if (skus.Count > 0)
                            {
                                maildata.skuList = skus;
                                string emailBody = _mail.GetEmailTemplate("SkuMail", maildata);

                                // Send the email
                                MailData mailData = new MailData(
                                    maildata.Email,
                                    "ReOrder Mail",
                                emailBody,
                                    _settings.From,
                                    null,
                                    null,
                                    null,
                                maildata.BccEmail,
                                null);

                                var sendResult = await _mail.SendAsync(mailData, new CancellationToken());

                                _logger.LogInformation("Email sent successfully to {ClientName}", maildata.client);

                            }


                        }
                        //await Task.Delay(60000, stoppingToken);

                    }
                }
                catch (Exception e)
                {
                    _logger.LogError("error at" + e.ToString());
                }

                await Task.Delay(60000, stoppingToken);
            }
        }
    }
}