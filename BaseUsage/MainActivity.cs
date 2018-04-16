using Android.App;
using Android.Widget;
using Android.OS;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight.Helpers;

namespace BaseUsage
{
    [Activity(Label = "BaseUsage", MainLauncher = true)]
    public class MainActivity : ActivityBase
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            EditText mEtInput = FindViewById<EditText>(Resource.Id.et_input);
            TextView mTvOutput = FindViewById<TextView>(Resource.Id.tv_output);

            this.SetBinding(()=>mEtInput.Text,()=>mTvOutput.Text);
        }
    }
}

