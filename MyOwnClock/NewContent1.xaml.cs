namespace MyOwnClock;

public partial class NewContent1 : ContentView
{
    public NewContent1()
    {
        InitializeComponent();
    }
    private int cur_digit;
    public void SetNumber(int number)
    {
        foreach (var i in all_num.Children)
        {
            (i as VisualElement).IsVisible = false;
        }

        (all_num.Children[number] as VisualElement).IsVisible = true;
        cur_digit = number;
    }
    public int GetNumber()
    {
        return cur_digit;
    }
}