﻿using System;
using System.Runtime.Serialization;

namespace Service.UserReward.Grpc.Models
{
	[DataContract]
	public class MascotInteractionGrpcRequset
	{
		[DataMember(Order = 1)]
		public Guid? UserId { get; set; }
	}
}