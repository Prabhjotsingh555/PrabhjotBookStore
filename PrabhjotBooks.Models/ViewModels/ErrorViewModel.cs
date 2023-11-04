using System;
using PrabhjotBookStore.Models.ViewModels;

namespace PrabhjotBookStore.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
