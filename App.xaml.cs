namespace PokerBot
{
    using System.Windows;

    using Akka.Actor;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //public ActorSystem System { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var system = ActorSystem.Create("poker-system");
            var uiProps = Props.Create(() => new WpfActor());
            var uiActor = system.ActorOf(uiProps, "ui");

            base.OnStartup(e);
        }
    }
}