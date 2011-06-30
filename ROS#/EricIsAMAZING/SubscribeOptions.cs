﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XmlRpc_Wrapper;
using m = Messages;
using gm = Messages.geometry_msgs;
using nm = Messages.nav_msgs;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace EricIsAMAZING
{
    public class SubscribeOptions<T> : StuffOptions where T : m.IRosMessage
    {
        public bool latch = false, has_header;
        public string topic, md5sum, datatype, message_definition;
        public SubscriptionCallbackHelper<T> helper;
        public SubscribeOptions(string topic, int queue_size)
        {
            // TODO: Complete member initialization
            this.topic = topic;
            this.queue_size = queue_size;
            helper  = new SubscriptionCallbackHelper<T>();
        }

        public SubscribeOptions(string topic, int queue_size, CallbackQueue cb)
        {
            // TODO: Complete member initialization
            this.topic = topic;
            this.queue_size = queue_size;
            this.callbackQueue = cb;
            helper = new SubscriptionCallbackHelper<T>(cb);
        }
    }

    public class StuffOptions
    {
        public CallbackQueue callbackQueue;
        public int queue_size;
    }
}
