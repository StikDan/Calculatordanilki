using Castle.Facilities.Startable;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers.SpecializedResolvers;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;

namespace CalculatorCsharp;
        public abstract class Operation //шаблон операций
        {
            public abstract string Name { get; }

            public abstract double Run(params double[] numbers);
        }

        public class Addition : Operation
        {
            public override string Name => "СЛОЖЕНИЕ";

            public override double Run(params double[] numbers)
            {
                return numbers.Sum();
            }
        }

        public class Substraction : Operation
        {
            public override string Name => "ВЫЧИТАНИЕ";

            public override double Run(params double[] numbers)
            {
                return 0d;
            }
        }

        public class Multiplacation : Operation
        {
            public override string Name => "УМНОЖЕНИЕ";

            public override double Run(params double[] numbers)
            {
                return 0d;
            }
        }

        public class Division : Operation
        {
            public override string Name => "ДЕЛЕНИЕ";

            public override double Run(params double[] numbers)
            {
                return 0d;
            }
        }

        public class Sqrt : Operation
        {
            public override string Name => "ВЫЧИСЛЕНИЕ КОРНЯ";

            public override double Run(params double[] numbers)
            {
                return 0d;
            }
        }



    

