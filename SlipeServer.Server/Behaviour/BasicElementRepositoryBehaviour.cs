﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Microsoft.Extensions.Logging;
using SlipeServer.Packets.Definitions.Commands;
using SlipeServer.Server.Elements;
using SlipeServer.Server.Repositories;

namespace SlipeServer.Server.Behaviour
{
    /// <summary>
    /// Behaviour responsible for adding elements to the element repository upon creation
    /// </summary>
    public class BasicElementRepositoryBehaviour
    {
        private readonly IElementRepository elementRepository;

        public BasicElementRepositoryBehaviour(IElementRepository elementRepository, MtaServer server)
        {
            this.elementRepository = elementRepository;

            server.ElementCreated += OnElementCreate;
        }

        private void OnElementCreate(Element element)
        {
            this.elementRepository.Add(element);
            element.Destroyed += OnElementDestroy;
        }

        private void OnElementDestroy(Element element)
        {
            this.elementRepository.Remove(element);
        }
    }
}
