using Android.Widget;
using EWiki.XF.Droid.Renderers;
using EWiki.XF.Droid.Utils.Typeface;
using EWiki.XF.ExtendedControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AdMobView), typeof(AdMobViewRender))]
namespace EWiki.XF.Droid.Renderers
{
    public class AdMobViewRender : ViewRenderer<AdMobView, Android.Gms.Ads.AdView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<AdMobView> e)
        {
            base.OnElementChanged(e);

            if (Control == null)
            {
                var ad = new Android.Gms.Ads.AdView(Forms.Context);
                ad.AdSize = Android.Gms.Ads.AdSize.Banner;
                ad.AdUnitId = "ca-app-pub-4803348967644542/1089645319";

                var requestbuilder = new Android.Gms.Ads.AdRequest.Builder();
                ad.LoadAd(requestbuilder.Build());

                SetNativeControl(ad);
            }
        }
    }
}