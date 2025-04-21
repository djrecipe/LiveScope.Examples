using LiveScope.Net;
using LiveScope.WPF.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LiveScope.WPF.Examples
{
    internal class MainWindowModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string[] _AcquisitionItems = { "Audio (Short)", "Audio (Long)", "Picoscope", "Generative", "CSV" };
        public string[] AcquisitionItems
        {
            get
            {
                return this._AcquisitionItems;
            }
            set
            {
                this._AcquisitionItems = value;
                this.OnPropertyChanged();
            }
        }
        public MainWindowModel()
        {
            LiveScope.Net.Licensing.LicenseKey = "PExpY2Vuc2U+DQogIDxJZD45MTJkNzVjZC1hODg1LTQyNWMtOTI2NC1hMjFmOWQ2ZTNjZDE8L0lkPg0KICA8VHlwZT5UcmlhbDwvVHlwZT4NCiAgPEV4cGlyYXRpb24+U2F0LCAxMyBTZXAgMjAyNSAwMTo1NjoyNyBHTVQ8L0V4cGlyYXRpb24+DQogIDxQcm9kdWN0RmVhdHVyZXM+DQogICAgPEZlYXR1cmUgbmFtZT0iQWxwaGEgQnVpbGQiPnllczwvRmVhdHVyZT4NCiAgPC9Qcm9kdWN0RmVhdHVyZXM+DQogIDxDdXN0b21lcj4NCiAgICA8TmFtZT5KdXN0aW48L05hbWU+DQogICAgPEVtYWlsPmp1c3RpbkBsaXZlc2NvcGUubmV0PC9FbWFpbD4NCiAgPC9DdXN0b21lcj4NCiAgPFNpZ25hdHVyZT5NRVVDSVFDWFpiMEh5RzFDTkJkc2FjQjJJWXNQWk1vd1l6czlMQXlwdHJOcC9JUzZzZ0lnQmowSncvZHhSSXR5cGgzOTZHa1lFWjRwelgwL0c3djIwSXVPV3dPRFBiaz08L1NpZ25hdHVyZT4NCjwvTGljZW5zZT4=";

        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private void InvokePropertyChangedEvent(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
            return;
        }

    }
}
