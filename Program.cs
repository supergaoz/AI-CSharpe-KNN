using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNN
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static List<List<int>> TrainInputs = null;
        public static List<int> TrainOutputs = null;

        public static void SetTrainData(List<List<int>> trainInputs, List<int> trainOutputs) {
            TrainInputs = trainInputs;
            TrainOutputs = trainOutputs;
        }

        public static int Predict(List<int> input)
        {
            return Predict(input,TrainInputs,TrainOutputs);
        }

        public static int Predict(List<int> input, List<List<int>> trainInputs, List<int> trainOutputs) {

            return 0;
        }
    }

}
