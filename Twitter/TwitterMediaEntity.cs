﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace SNSDownloader.Twitter
{
    public class TwitterMediaEntity
    {
        public string Url { get; set; } = string.Empty;

        public TwitterMediaEntity()
        {

        }

        public TwitterMediaEntity(JToken json) : this()
        {

        }

    }

}