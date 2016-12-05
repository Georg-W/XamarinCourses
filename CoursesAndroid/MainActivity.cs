using Android.App;
using Android.Widget;
using Android.OS;
using ClassLibrary1;
using System;

namespace CoursesAndroid
{
    [Activity(Label = "CoursesAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button buttonPrev;
        Button buttonNext;
        TextView textTitle;
        ImageView imageCourse;
        TextView textDescription;
        CourseManager courseManager;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);

            buttonPrev = FindViewById<Button>(Resource.Id.buttonPrev);
            buttonNext = FindViewById<Button>(Resource.Id.buttonNext);
            textTitle = FindViewById<TextView>(Resource.Id.textTitle);
            imageCourse = FindViewById<ImageView>(Resource.Id.imageCourse);
            textDescription = FindViewById<TextView>(Resource.Id.textDescription);

            buttonPrev.Click += ButtonPrev_Click;
            buttonNext.Click += ButtonNext_Click;

            courseManager = new CourseManager();
            courseManager.MoveFirst();
            UpdateUI();

        }

        private void ButtonPrev_Click(object sender, System.EventArgs e)
        {
            courseManager.MovePrev();
            UpdateUI();
            //textTitle.Text = "Prev clicked";
            //textDescription.Text = "The description for Prev";
            //imageCourse.SetImageResource(Resource.Drawable.diedrei);
        }

        private void ButtonNext_Click(object sender, System.EventArgs e)
        {
            courseManager.MoveNext();
            UpdateUI();
            //textTitle.Text = "Next clicked";
            //textDescription.Text = "The description for Next";
            //imageCourse.SetImageResource(Resource.Drawable.Herrderringe);
        }

        private void UpdateUI()
        {
            textTitle.Text = courseManager.Current.Title;
            textDescription.Text = courseManager.Current.Title;
            imageCourse.SetImageResource(Resource.Drawable.Herrderringe);
            buttonPrev.Enabled = courseManager.canMovePrev;
            buttonNext.Enabled = courseManager.canMoveNext;
        }
    }
}

