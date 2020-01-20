using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PatternProject.Models;

namespace PatternProject.Test
{
    [TestClass]
    public class UnitTest1
    {
        Mock<IGalleryItem> galleryItem;

        [TestInitialize]
        public void Initialization()
        {
            galleryItem = new Mock<IGalleryItem>();
        }

        //[TestMethod]

    }
}
