using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BethanysPieShopMobile.Models
{
    public class Pie : INotifyPropertyChanged
    {
        private int _id;
        private string _pieName;
        private string _description;
        private double _price;
        private string _imageUrl;
        private bool _iStock;

        public int Id
        {
            get => _id;
            set
            {
                if (_id != value)
                {
                    _id = value;
                    RaisePropertyChanged();
                }
            }
        }
        public string PieName
        {
            get => _pieName;
            set
            {
                if (_pieName != value)
                {
                    _pieName = value;
                    RaisePropertyChanged();
                }
            }
        }
        public string Description
        {
            get => _description;
            set
            {
                if (_description != value)
                {
                    _description = value;
                    RaisePropertyChanged();
                }
            }
        }
        public double Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    RaisePropertyChanged();
                }
            }
        }
        public string ImageUrl
        {
            get => _imageUrl;
            set
            {
                if (_imageUrl != value)
                {
                    _imageUrl = value;
                    RaisePropertyChanged();
                }
            }
        }
        public bool InStock
        {
            get => _iStock;
            set
            {
                if (_iStock != value)
                {
                    _iStock = value;
                    RaisePropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
