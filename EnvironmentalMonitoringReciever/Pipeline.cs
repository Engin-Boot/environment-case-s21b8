using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentalMonitoringReciever
{
    interface IPipelineElement
    {
        /// <summary>
        /// Set the input for this pipeline element
        /// </summary>
        /// <param name="inputStream">The stream</param>
        void SetInput(PipeStream inputStream);

        /// <summary>
        /// The output of this element will be connected to the input of the next element.
        /// </summary>
        /// <param name="next">The next element to be connected</param>
        void Connect(IPipelineElement next);

        /// <summary>
        /// The pipeline elements processing function. Implement your processing here.
        /// </summary>
        void Process();

        /// <summary>
        /// Is the processing complete with respect to this particular pipeline element.
        /// </summary>
        bool IsComplete
        {
            get;
        }
    }
}
