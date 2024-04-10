namespace TurningImages
{
    public partial class MainPage : ContentPage
  
    {
        String img1_str = "one.png";
        String img2_str = "two.png";
        String img3_str = "three.png";
        String img4_str = "four.png";


        public MainPage()
        {
            InitializeComponent();
        }

        private void change_Clicked(object sender, EventArgs e)
        {
            String first;
            first = img4_str;
            img4_str = img3_str;
            img3_str = img2_str;
            img2_str = img1_str;
            img1_str = first;

            img1.Source = img1_str;
            img2.Source = img2_str;
            img3.Source = img3_str;
            img4.Source = img4_str;


        }
    }

}
