using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Behavioral
{
    public class Strategy
    {
        public IStrategy Algorithm { private get; set; }

        public void DoStrategy()
        {
            Algorithm.DoAlgorithm("Strategy");
        }
    }

    public interface IStrategy
    {
        string DoAlgorithm(string data);
    }

    public class StrategyA : IStrategy
    {
        public string DoAlgorithm(string data)
        {
            return data + 'A';
        }
    }

    public class StrategyB : IStrategy
    {
        public string DoAlgorithm(string data)
        {
            return data + 'B';
        }
    }

    public class UseStrategy{
        public void DoStrategy()
        {
            var strategy = new Strategy();
            strategy.Algorithm = new StrategyA();
            strategy.DoStrategy();
            strategy.Algorithm = new StrategyB();
            strategy.DoStrategy();
        }
    }
}
