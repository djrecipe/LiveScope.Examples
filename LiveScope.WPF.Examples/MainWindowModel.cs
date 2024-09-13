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
            LiveScope.Net.Licensing.LicenseKey = "PExpY2Vuc2U+DQogIDxJZD40ZWVhMDU2Ni04YjE5LTRlZjktOGJjYS00MjY5NWZjODc4YWE8L0lkPg0KICA8VHlwZT5UcmlhbDwvVHlwZT4NCiAgPEV4cGlyYXRpb24+VHVlLCAzMSBEZWMgMjAyNCAxNzowMDowMCBHTVQ8L0V4cGlyYXRpb24+DQogIDxDdXN0b21lcj4NCiAgICA8TmFtZT5KdXN0aW48L05hbWU+DQogICAgPEVtYWlsPmp1c3RpbkBsaXZlc2NvcGUubmV0PC9FbWFpbD4NCiAgPC9DdXN0b21lcj4NCiAgPFNpZ25hdHVyZT5NRVVDSUNxTWdDbkMrRWc5Vmh5YnE3L0NUQmVqNDRBRjdWNnpuSEliemsrN1BLWVhBaUVBeUhwdE0wcWd1TUFCd1R5b2ozVWwvdXh6OS82aFZUOURLb3N2blVLaUVTWT08L1NpZ25hdHVyZT4NCjwvTGljZW5zZT4=";

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
