using GalaSoft.MvvmLight;
using Zad3.Implementations.Services;
using Zad3.Interfaces.Models;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using Zad3.Implementations.Models;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows;
using Zad3.Interfaces.Services;

namespace Zad3.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<IBaseEntity> _basketItems = new ObservableCollection<IBaseEntity>();
        private bool _isItemInBasket = true;

        private int _minIndex = 0;
        private int _maxIndex;
        private int _currentIndex = 0;

        private IBaseEntity _currentSelectedCatalogItem = default;

        private readonly List<IBaseEntity> _catalogItems;

        public ObservableCollection<IBaseEntity> BasketItems
        {
            get { return _basketItems; }
            set
            {
                _basketItems = value;
                RaisePropertyChanged(nameof(BasketItems));
            }
        }

        public bool IsItemInBasket
        {
            get { return _isItemInBasket; }
            set
            {
                _isItemInBasket = value;
                RaisePropertyChanged(nameof(IsItemInBasket));
            }
        }

        public IBaseEntity CurrentSelectedCatalogItem
        {
            get { return _currentSelectedCatalogItem; }
            set
            {
                _currentSelectedCatalogItem = value;
                RaisePropertyChanged(nameof(CurrentSelectedCatalogItem));
                DisableAddIfInBasket();
                ShowValues();
            }
        }

        private ICar _carItemSelected;

        public ICar CarItemSelected
        {
            get { return _carItemSelected; }
            set
            {
                _carItemSelected = value;
                RaisePropertyChanged(nameof(CarItemSelected));
            }
        }

        private Visibility _isCarGridVisible;

        public Visibility IsCarGridVisible
        {
            get { return _isCarGridVisible; }
            set
            {
                _isCarGridVisible = value;
                RaisePropertyChanged(nameof(IsCarGridVisible));
            }
        }


        private Visibility _isHouseGridVisible;

        public Visibility IsHouseGridVisible
        {
            get { return _isHouseGridVisible; }
            set
            {
                _isHouseGridVisible = value;
                RaisePropertyChanged(nameof(IsHouseGridVisible));
            }
        }

        private Visibility _isPersonGridVisible;

        public Visibility IsPersonGridVisible
        {
            get { return _isPersonGridVisible; }
            set
            {
                _isPersonGridVisible = value;
                RaisePropertyChanged(nameof(IsPersonGridVisible));
            }
        }

        public ICommand AddItemToBasketCommand { get; private set; }
        public ICommand MoveRightCommand { get; private set; }
        public ICommand MoveLeftCommand { get; private set; }


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(ICatalogDataService catalogDataService)
        {
            AddItemToBasketCommand = new RelayCommand(AddItemToBasketMethod);
            MoveLeftCommand = new RelayCommand(MoveLeftMethod);
            MoveRightCommand = new RelayCommand(MoveRightMethod);

            _catalogItems = catalogDataService.GetAllCatalogItems();

            _maxIndex = _catalogItems.Count - 1;

            SelectFirstFromCatalog();
        }


        private void AddItemToBasketMethod()
        {
            BasketItems.Add(CurrentSelectedCatalogItem);
            DisableAddIfInBasket();
        }

        private void MoveRightMethod()
        {
            int index = _currentIndex;

            index += 1;

            if (index > _maxIndex) index = _maxIndex;

            _currentIndex = index;

            CurrentSelectedCatalogItem = _catalogItems[index];
        }

        private void MoveLeftMethod()
        {
            int index = _currentIndex;

            index -= 1;

            if (index < 0) index = 0;

            _currentIndex = index;

            CurrentSelectedCatalogItem = _catalogItems[index];
        }


        private void SelectFirstFromCatalog()
        {
            CurrentSelectedCatalogItem = _catalogItems[0];
        }

        private void DisableAddIfInBasket()
        {
            IsItemInBasket = !BasketItems.Contains(CurrentSelectedCatalogItem);
        }

        private void ShowValues()
        {
            IsCarGridVisible = Visibility.Hidden;
            IsHouseGridVisible = Visibility.Hidden;
            IsPersonGridVisible = Visibility.Hidden;

            var currentSelectedTypeOfObject = CurrentSelectedCatalogItem.GetType();

            if (currentSelectedTypeOfObject.Name == typeof(Car).Name)
            {
                IsCarGridVisible = Visibility.Visible;
            }
            else if (currentSelectedTypeOfObject.Name == typeof(House).Name)
            {
                IsHouseGridVisible = Visibility.Visible;
            }
            else if (currentSelectedTypeOfObject.Name == typeof(Person).Name)
            {
                IsPersonGridVisible = Visibility.Visible;
            }
        }

    }
}