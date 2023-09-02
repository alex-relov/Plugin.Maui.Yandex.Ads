﻿#if IOS || MACCATALYST
using UIKit;
#elif ANDROID
using Microsoft.Maui;
using PlatformView = Com.Yandex.Mobile.Ads.Banner.BannerAdView;
using Com.Yandex.Mobile.Ads.Banner;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID)                                                                      
using PlatformView = System.Object;
#endif

using Microsoft.Maui.Handlers;

namespace Plugin.Maui.Yandex.Ads;

    public partial class BannerHandler
    {
        public static IPropertyMapper<Banner, BannerHandler> PropertyMapper = new PropertyMapper<Banner, BannerHandler>(ViewHandler.ViewMapper)
        {
            //[nameof(Video.AreTransportControlsEnabled)] = MapAreTransportControlsEnabled,
            //[nameof(Video.Source)] = MapSource,
            //[nameof(Video.IsLooping)] = MapIsLooping,
            //[nameof(Video.Position)] = MapPosition
        };

        public static CommandMapper<Banner, BannerHandler> CommandMapper = new(ViewCommandMapper)
        {
            //[nameof(Video.UpdateStatus)] = MapUpdateStatus,
            //[nameof(Video.PlayRequested)] = MapPlayRequested,
            //[nameof(Video.PauseRequested)] = MapPauseRequested,
            //[nameof(Video.StopRequested)] = MapStopRequested
        };

        public BannerHandler() : base(PropertyMapper, CommandMapper)
        {
        }
    }