﻿namespace Own.SmartphoneLib
{
    public class CSVSerializer : ISerializable
    {
        public void Serialize(string path, SmartphoneList spList)
        {

        }

        public SmartphoneList Deserialize(string path)
        {
            return new SmartphoneList();
        }
    }
}
