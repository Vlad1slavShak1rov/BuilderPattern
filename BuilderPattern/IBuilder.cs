using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IBuilder
    {
        void AddMotherboard(Motherboard motherboard);
        void AddProcessor(Processor processor);
        void AddRAM(RAM rAM);
        void AddStorage(Storage storage);
        void AddGCard(GraphicCards graphicCards);

        Computer GetComputer();
    }
}
