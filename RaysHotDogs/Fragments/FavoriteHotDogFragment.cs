using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using RaysHotDogs.Adapters;

namespace RaysHotDogs.Fragments
{
    public class FavoriteHotDogFragment : BaseFragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);

            FindViews();
            HandleEvents();
            hotDogs = hotDogDataService.GetFavoriteHotDogs();
            listView.Adapter = new HotDogListAdapter(this.Activity, hotDogs);

        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);

            // return base.OnCreateView(inflater, container, savedInstanceState);
            return inflater.Inflate(Resource.Layout.FavoriteHotDogFragment, container, false);
        }
    }
}