using Xamarin.Forms;

namespace WorkingWithWebview
{
    public class LocalHtml : ContentPage
    {
        public LocalHtml()
        {
            var browser = new WebView();

            var htmlSource = new HtmlWebViewSource();

            htmlSource.Html = @"<html><header><link rel=""stylesheet"" href=""https://unpkg.com/leaflet@1.3.4/dist/leaflet.css""
            integrity = ""sha512-puBpdR0798OZvTTbP4A8Ix/l+A4dHDD0DGqYW6RQ+9jxkRFclaxxQb/SJAWZfWAkuyeQUytO7+7N4QKrDh+drA==""
   crossorigin = "" "" /></header>< body>
<script src=""https://unpkg.com/leaflet@1.3.4/dist/leaflet.js""
            integrity = ""sha512-nMMmRyTVoLYqjP9hrbed9S+FzjZHW5gY1TWCHA5ckwXZBadntCNs8kEqAWdrb9O7rxbCaA4lKTIWjDXZxflOcA==""
   crossorigin = "" "" ></ script >  <div id=""mapid""></div>
</body> #mapid { height: 180px; } <script>var mymap = L.map('mapid').setView([51.505, -0.09], 13);</script>
</html>";

            browser.Source = htmlSource;
            Content = browser;
        }
    }
}
