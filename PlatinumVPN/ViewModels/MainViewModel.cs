using Avalonia.Controls;
using Avalonia.Media;
using PlatinumVPN.Utilities;
using PlatinumVPN.Views;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Net.Http;
using System.Security.Principal;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.JSInterop;
using Avalonia.Interactivity;
using System.Runtime.InteropServices;
using System.Reactive;
using System.Xml.Linq;


namespace PlatinumVPN.ViewModels;

public class MainViewModel : ViewModelBase
{
    int _selectMenuIndex;
    char _firstLetter;
    private string _sessionKey;
    object _menuFrameView;
    bool _isPaneOpen, _isVisible;
    //private readonly CookieService _cookieService;

    private string _cookieValue;
    public string CookieValue
    {
        get => _cookieValue;
        set
        {
            if (_cookieValue != value)
            {
                this.RaiseAndSetIfChanged(ref _cookieValue, value);
            }
        }
    }

    public object MenuFrameView
    {
        get => _menuFrameView;
        set => this.RaiseAndSetIfChanged(ref _menuFrameView, value);
    }
    public char FirstLetter
    {
        get => _firstLetter;
        set => this.RaiseAndSetIfChanged(ref _firstLetter, value);
    }
    public bool IsPaneOpen
    {
        get => _isPaneOpen;
        set => this.RaiseAndSetIfChanged(ref _isPaneOpen, value);
    }
    public bool IsVisible
    {
        get => _isVisible;
        set => this.RaiseAndSetIfChanged(ref _isVisible, value);
    }
    //public AccountReply Account
    //{
    //    get => account;
    //    set => this.RaiseAndSetIfChanged(ref account, value);
    //}

    public int SelectMenuIndex
    {
        get => _selectMenuIndex;
        set
        {
            this.RaiseAndSetIfChanged(ref _selectMenuIndex, value);
            if (value == 0)
            {
                
            }
            else if (_selectMenuIndex == 9)
            {
                //MenuFrameView = new SettingsPage(Account)
                //{
                //    // DataContext =new SettingsPageViewModel(Account)
                //};
            }
            else if (_selectMenuIndex == 12)
            {
                //Client.RemoveSession(new UserSessionKeyRequest { SessionKey = UserData.SessionKey });
                ////UpdSaveUserData();
                //PageFrameView = new MainView()
                //{
                //    DataContext = new ViewModels.MainViewModel()
                //};
            }
        
        }
    }
    public ReactiveCommand<Unit, Unit> SetUserCookie { get; }
    private readonly CookieService _cookieService;
    public MainViewModel()
    {
        SetUserCookie = ReactiveCommand.Create(()=> SetUserCookie1());
       // IsVisible = true;
        //IsVisible = true; 
        // }
    }

    private async  void SetUserCookie1()
    {
        // Установка куки с именем "username", значением "JohnDoe" на 7 дней
        //CookieService1 cs = new();
       
        await CookieService.SetCookie("sessionKey", "Залупа", 7);
        IsVisible = true;
        //CookieValue = "123";
        CookieValue = await CookieService.GetCookie("sessionKey");
    }
    private async Task GetCookieValue()
    {
        //CookieValue = await _cookieService.GetCookie("myCookieKey");
    }

    private async Task SetCookieValue(string value)
    {
        //_cookieManager.Set("Key1", value, 100000);
        //await _cookieService.SetCookie("myCookieKey", value, 30); // 30 days expiration
    }
    public async void MenuCommand()
    {
       
    }
}
