using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace CustomHelp
{
    public static class CustomHelpProvider
    {
        public static readonly DependencyProperty HelpStringProperty =
            DependencyProperty.RegisterAttached("HelpString", typeof(string), typeof(CustomHelpProvider));

        public static string GetHelpString(DependencyObject obj)
        {
            return (string)obj.GetValue(HelpStringProperty);
        }

        public static void SetHelpString(DependencyObject obj, string value)
        {
            obj.SetValue(HelpStringProperty, value);
        }

        static CustomHelpProvider()
        {
            CommandManager.RegisterClassCommandBinding(
                typeof(FrameworkElement),
                new CommandBinding(ApplicationCommands.Help,
                new ExecutedRoutedEventHandler(Executed),
                new CanExecuteRoutedEventHandler(CanExecute)));
        }

        static private void CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            FrameworkElement fe = sender as FrameworkElement;

            if (CustomHelpProvider.GetHelpString(fe) != null)
                e.CanExecute = true;
        }

        static private void Executed(object sender, ExecutedRoutedEventArgs e)
        {
            FrameworkElement fe = sender as FrameworkElement;

            TextBlock tb = new TextBlock();

            tb.Text = CustomHelpProvider.GetHelpString(fe);

            Point leftUp = fe.TranslatePoint(new Point(10.0, 10.0), null);

            tb.HorizontalAlignment = HorizontalAlignment.Left;
            tb.VerticalAlignment = VerticalAlignment.Top;
            tb.Margin = new Thickness(leftUp.X, leftUp.Y, 2, 2);
            tb.Padding = new Thickness(2, 2, 2, 2);
            tb.TextAlignment = TextAlignment.Center;
            tb.MaxWidth = 100;
            tb.MaxHeight = 50;
            tb.TextWrapping = TextWrapping.Wrap;
            tb.Background = Brushes.Purple;

            tb.MouseLeftButtonUp += Tb_MouseLeftButtonUp;

            Window rootWindow = Window.GetWindow(fe);
            ((Panel)rootWindow.Content).Children.Add(tb);
        }

        private static void Tb_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ((Panel)((TextBlock)sender).Parent).Children.Remove((UIElement)sender);
        }
    }
}
