using System;
using System.Collections.Generic;
using CPL.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class CollectionsUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var list = new List<string> { "test1", "test1", "test3", "test4"};
            var result = list.DuplicateCount();
            
            var assert = new List<Tuple<string, int>> {Tuple.Create("test1", 2), Tuple.Create("test3", 1), Tuple.Create("test4", 1)};
            CollectionAssert.AreEqual(result, assert);
        }
    }
}