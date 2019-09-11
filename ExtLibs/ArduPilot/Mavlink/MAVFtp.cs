using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Core.ExtendedObjects;
//using log4net;
using Newtonsoft.Json;
using uint8_t = System.Byte;
using uint16_t = System.UInt16;
using uint32_t = System.UInt32;
using MissionPlanner.Utilities;

namespace MissionPlanner.ArduPilot.Mavlink
{
    public class RetryTimeout
    {
        public bool Complete = false;
        public int Retries = 3;
        public int RetriesCurrent = 0;
        public int TimeoutMS = 1000;
        public Action WorkToDo;
     //   private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private DateTime _timeOutDateTime = DateTime.MinValue;

        public RetryTimeout(int Retrys = 30, int TimeoutMS = 1000)
        {
            this.Retries = Retrys;
            this.TimeoutMS = TimeoutMS;
        }

        public DateTime TimeOutDateTime
        {
            get
            {
                lock (this) return _timeOutDateTime;
            }
            set
            {
                lock (this) _timeOutDateTime = value;
            }
        }

        public bool DoWork()
        {
            if (WorkToDo == null)
                throw new ArgumentNullException("WorkToDo");
            return Task.Run<bool>(() =>
            {
                Complete = false;
                for (RetriesCurrent = 0; RetriesCurrent < Retries; RetriesCurrent++)
                {
                  // log.infoFormat("Retry {0} - {1}", RetriesCurrent,
                        //TimeOutDateTime.ToString("yyyy-MM-ddTHH:mm:ss.fff"));
                    WorkToDo();
                    TimeOutDateTime = DateTime.Now.AddMilliseconds(TimeoutMS);
                    while (DateTime.Now < TimeOutDateTime)
                    {
                        if (Complete)
                            return true;
                        Thread.Sleep(100);
                      // log.Debug("TimeOutDateTime " + TimeOutDateTime.ToString("yyyy-MM-ddTHH:mm:ss.fff"));
                    }
                }

                return false;
            }).Result;
        }

        public void ResetTimeout()
        {
            TimeOutDateTime = DateTime.Now.AddMilliseconds(TimeoutMS);
        }
    }
}