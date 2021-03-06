﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using ProtoBuf;
using Sandbox.Common.ObjectBuilders;
using Sandbox.Common.ObjectBuilders.Definitions;
using Sandbox.Common.ObjectBuilders.VRageData;

namespace Medieval.ObjectBuilders.Definitions
{
    /// <summary>
    /// Definition for large grid block which consists of several connected small grid cog wheel subblocks.
    /// </summary>
    [ProtoContract]
    [MyObjectBuilderDefinition]
    public class MyObjectBuilder_CogWheelsBlockDefinition : MyObjectBuilder_MechanicalTransferBlockDefinition
    {
        [ProtoContract]
        public class MyOBCogWheelConnection
        {
            [XmlAttribute]
            [ProtoMember(1)]
            public string Wheel1;

            [XmlAttribute]
            [ProtoMember(2)]
            public float Radius1;

            [XmlAttribute]
            [ProtoMember(3)]
            public string Wheel2;

            [XmlAttribute]
            [ProtoMember(4)]
            public float Radius2;
        }

        [XmlArrayItem("Connection")]
        [ProtoMember(1), DefaultValue(null)]
        public MyOBCogWheelConnection[] CogWheelConnections = null;
    }
}
