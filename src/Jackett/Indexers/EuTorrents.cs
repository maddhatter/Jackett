﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jackett.Models;
using Newtonsoft.Json.Linq;
using NLog;
using Jackett.Utils;
using System.Net;
using System.Net.Http;
using CsQuery;
using System.Web;
using Jackett.Services;
using Jackett.Utils.Clients;
using System.Text.RegularExpressions;
using Jackett.Models.IndexerConfig;

namespace Jackett.Indexers
{
    public class EuTorrents : AvistazTracker, IIndexer
    {
        public EuTorrents(IIndexerManagerService indexerManager, IWebClient webClient, Logger logger, IProtectionService protectionService)
            : base(name: "EuTorrents",
                desc: "Part of the Avistaz network.",
                link: "https://eutorrents.to/",
                indexerManager: indexerManager,
                logger: logger,
                protectionService: protectionService,
                webClient: webClient
                )
        {
        }
    }
}