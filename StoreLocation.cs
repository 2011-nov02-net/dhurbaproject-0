using System;
using System.Collections.Generic;
using System.Text;

namespace dhurbaproject_0
{
    public class StoreLocation
    {
        //list of all 3 store
        public static List<StoreLocation> allStore = new List<StoreLocation>();
        public string Name { get; }
        public string Location { get; }
        public string Id { get; }

        public StoreLocation(string id, string name, string location)
        {
            Id = id;
            Location = location;
            Name = name;

        }

        //Add store to the store list allstore
        public static void AddStore(StoreLocation store)
        {
            allStore.Add(store);

        }
    }
}
