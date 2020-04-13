using System;
using System.Collections;
using BlabberApp.DataStore.Interfaces;
using BlabberApp.Domain.Entities;

namespace BlabberApp.DataStore.Adapters
{
    public class BlabAdapter
    {
        //Attributes
        private iBlabPlugin plugin;


        //Constructor
        public BlabAdapter(iBlabPlugin plugin) 
        {
            this.plugin = plugin;
        }


        //Methods
        public void Add(Blab blab)
        {
            this.plugin.Create(blab);
        }

        public void Remove(Blab blab)
        {
            this.plugin.Delete(blab);
        }

        public void Update(Blab blab)
        {
            this.plugin.Update(blab);
        }

        public IEnumerable GetAll()
        {
            return this.plugin.ReadAll();
        }

        public Blab GetById(Guid Id)
        {
            return (Blab)this.plugin.ReadById(Id);
        }

        public IEnumerable GetByUserId(string Id)
        {
            return this.plugin.ReadByUserId(Id);
        }
    }
}