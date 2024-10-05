using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public  class DirectorPC
    {
        private readonly IBuilder _builder;

        public DirectorPC(IBuilder builder)
        {
            _builder = builder;
        }

        public void Build(Processor processor, Motherboard motherboard, RAM ram, Storage storage, GraphicCards graphicCards)
        {
            _builder.AddMotherboard(motherboard);
            _builder.AddProcessor(processor);
            _builder.AddStorage(storage);
            _builder.AddGCard(graphicCards);
            _builder.AddRAM(ram);
        }
    }
}
