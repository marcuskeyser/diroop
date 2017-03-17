using ecsCore.Data;
using ecsCore.Domain.POCO;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using Xunit;

namespace ecsCore.Tests
{
    public class _TesterMethods

    {
        public void PassTest() {
            Assert.Equal(true, true);
        }
        public void FailTest() {
            Assert.Equal(true, false);
        }

    }
}
