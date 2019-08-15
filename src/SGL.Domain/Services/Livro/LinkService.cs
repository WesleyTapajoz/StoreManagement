﻿using SGL.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using SGL.Domain.Entity;
using SGL.Domain.Interfaces.Repository;

namespace SGL.Domain.Services
{
    public class LinkService : Service<Link, string>, ILinkService
    {
        private readonly ILinkRepository _linkRepository;

        public LinkService(ILinkRepository linkRepository) : base(linkRepository)
        {
            _linkRepository = linkRepository;
        }
    }
}
