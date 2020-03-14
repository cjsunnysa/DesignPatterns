using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Timers;

namespace DesignPatterns.Observer
{
    public class WeatherStation : IObservable<int>
    {
        private int _temp;
        private readonly List<IObserver<int>> _observers;
        private readonly Random _random;
        
        private int CurrentTemperature
        {
            get => _temp;
            set
            {
                _temp = value;
                NotifyObservers(value);
            }
        }

        public WeatherStation()
        {
            _observers = new List<IObserver<int>>();
            _random = new Random(DateTime.Now.Millisecond);
            _temp = 20;
        }
        
        
        public void Run()
        {
            var stopWatch = new Stopwatch();
            var timer = new Timer(2000);

            timer.Elapsed += UpdateTemperature;

            stopWatch.Start();
            timer.Start();

            while (stopWatch.ElapsedMilliseconds < 30000)
            { }

            timer.Stop();
            stopWatch.Stop();

            NotifyObserversComplete();
        }
        
        public IDisposable Subscribe(IObserver<int> observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);

            return new Unsubscriber<int>(_observers, observer);
        }

        
        private void UpdateTemperature(object sender, ElapsedEventArgs e)
        {
            try
            {
                var temperatureChange = _random.Next(-2, 2);

                CurrentTemperature += temperatureChange;
            }
            catch (Exception ex)
            {
                NotifyObservers(ex);
            }
        }

        private void NotifyObservers(int temp)
        {
            foreach (var observer in _observers)
                observer.OnNext(temp);
        }

        private void NotifyObservers(Exception ex)
        {
            foreach (var observer in _observers)
                observer.OnError(ex);
        }

        private void NotifyObserversComplete()
        {
            foreach (var observers in _observers)
                observers.OnCompleted();
        }
    }
}
