﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fantasizer.Tests.Utilities;
using Fantasizer.Domain;

namespace Fantasizer.Tests
{
    [TestClass]
    public class TeamTests
    {
        [ClassInitialize]
        public static void Setup(TestContext testContext)
        {
            AppHarborUtil.CheckSecrets();
        }

        [TestMethod]
        public void GetLeagueKeyFromTeam()
        {
            var service = new FantasizerService(ClientTestConfiguration.ConsumerKey, ClientTestConfiguration.ConsumerSecret, new TestUserTokenStore());
            
            var team = service.GetTeam(ClientTestConfiguration.DEFAULT_TEAM_KEY);

            Assert.AreEqual("273.l.86177", team.LeagueKey);
        }
    }
}
