using System.Windows;
using DevExpress.Mvvm;
using IocApp.CIL;
using IocApp.CIL.Ribbon;

namespace IocApp.PLL.Ribbon
{
    public class ItemVM : IItem
    {
        #region | Fields |

        private static ILogger _logger;
        private static IMessageBoxService _messageBoxService;
        private static INotificationService _notificationService;

        #endregion

        #region | Properties |

        public virtual string Name { get; set; }

        public virtual string Hint { get; set; }

        #endregion

        #region | Constructor |

        public ItemVM(ILogger logger, IMessageBoxService messageBoxService, INotificationService notificationService)
        {
            if (_logger == null)
            {
                _logger = logger;
                _messageBoxService = messageBoxService;
                _notificationService = notificationService;
            }
        }

        #endregion

        #region | Methods |

        public void Click()
        {
            _logger.Debug(Name + " is clicked");

            var notify = _notificationService.CreatePredefinedNotification("NotificationService", Name + " is clicked",
                "");
            notify.ShowAsync();

            _messageBoxService.Show(Name + " is clicked", "MessageBoxService",
                MessageBoxButton.OK, MessageBoxImage.Information, MessageBoxResult.OK);
        }

        #endregion
    }
}
