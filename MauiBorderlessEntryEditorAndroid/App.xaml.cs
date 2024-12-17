


using Microsoft.Maui.Platform;

namespace MauiBorderlessEntryEditorAndroid
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

//#if ANDROID
//            Microsoft.Maui.Handlers.EntryHandler.Mapper
//                .AppendToMapping(nameof(Entry),
//                (handler, view) =>
//                {
//                    handler.PlatformView.BackgroundTintList =
//                        Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
//                });

//            Microsoft.Maui.Handlers.EditorHandler.Mapper
//                .AppendToMapping(nameof(Editor),
//                (handler, view) =>
//                {
//                    handler.PlatformView.BackgroundTintList =
//                        Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
//                });
//#endif
        }
    }
}
