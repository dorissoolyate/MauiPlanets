namespace Views;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        if (this.AnimationIsRunning("TransirionAnimation"))
        {
            return;
        }

        var parentAnimantion = new Animation();

        //PlanetsAnimation
        parentAnimantion.Add(0, 0.2, new Animation(v => imgMercury.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimantion.Add(0, 0.2, new Animation(v => imgVenus.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimantion.Add(0, 0.2, new Animation(v => imgEarth.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimantion.Add(0, 0.2, new Animation(v => imgMars.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimantion.Add(0, 0.2, new Animation(v => imgJupiter.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimantion.Add(0, 0.2, new Animation(v => imgSaturn.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimantion.Add(0, 0.2, new Animation(v => imgUranus.Opacity = v, 0, 1, Easing.CubicIn));
        parentAnimantion.Add(0, 0.2, new Animation(v => imgNeptune.Opacity = v, 0, 1, Easing.CubicIn));

        //intro Box
        parentAnimantion.Add(0.7, 1, new Animation(v => imgIntro.Opacity = v, 0, 1, Easing.CubicIn));

        parentAnimantion.Commit(this, "TransitionAnimation", 16, 3000, null, null);

    }




}