using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security
{
    public class SharpMiner
    {

        public string CreateBlockChain(string userId,int mayoralId,int partyId)
        {
            BlockChain blockChain = new BlockChain(new Block()
            {
                Data = new List<Transaction>(),
                Hash = "00000000000000000000000000000000000000000000000000000000",
                Nonce = 1,
                PrevHash = "00000000000000000000000000000000000000000000000000000",
                TimeStamp = DateTime.UtcNow
            });
            for (int i = 0; i < 5; i++)
            {
                List<Transaction> lstT = new List<Transaction>();
                lstT.Add(new Transaction()
                {
                    UserId = userId,
                    MayorId = mayoralId,
                    PartyId=partyId
                });
                Block b = new Block()
                {
                    Data = lstT,
                    TimeStamp = DateTime.UtcNow
                };
                blockChain.Mine(b);
            }

            //foreach (var item in blockChain.Chain.ToArray())
            //{
            //    //hash = item.Hash;
            //    Console.WriteLine("Nonce     = " + item.Nonce);
            //    Console.WriteLine("Prev Hash = " + item.PrevHash);
            //    Console.WriteLine("Hash      = " + item.Hash);
            //}
            ////Console.WriteLine("bitti.");
            //Console.WriteLine();
            ////Console.WriteLine(hash);
            //Console.WriteLine("bitti.");
            ////Console.WriteLine(DateTime.UtcNow);
            //Console.WriteLine(blockChain.Chain.ToArray()[blockChain.Chain.Count - 1].Hash);
            //Console.ReadLine();
            return blockChain.Chain.ToArray()[blockChain.Chain.Count - 1].Hash;

        }
    }
}
