using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptiveVectorQuantization
{
    class SimulationResult
    {
        public string CompressionTime { get; set; }
        public string DeompressionTime { get; set; }
        public int BlocksNumber { get; set; }
        public long CompressedFileSize { get; set; }
        public long DecompressedFileSize { get; set; }
        public float PSNR { get; set; }

        public SimulationResult(string compressionTime, string deompressionTime, int blocksNumber, long compressedFileSize, long decompressedFileSize, float pSNR)
        {
            CompressionTime = compressionTime;
            DeompressionTime = deompressionTime;
            BlocksNumber = blocksNumber;
            CompressedFileSize = compressedFileSize;
            DecompressedFileSize = decompressedFileSize;
            PSNR = pSNR;
        }
    }
}
