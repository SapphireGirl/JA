using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq.Linq;
using Amazon.S3;
using System.Collections;

namespace JA.Tests
{
    [TestClass]
    public class S3_UnitTests
    {
        // Amazon.S3.Util.S3PostUploadException 
        [TestMethod]
        public void ListAllS3Buckets()
        {
            var S3 = new Amazon.S3.AmazonS3Client();
            
            var S3Buckets = new List<string>();
        }

        private void S3List()
        {
            try
            {

            }
            catch (AmazonS3Exception e)
            {

            }
        }
    }
}
