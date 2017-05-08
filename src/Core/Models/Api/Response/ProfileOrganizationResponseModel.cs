﻿using Bit.Core.Enums;
using Bit.Core.Models.Data;

namespace Bit.Core.Models.Api
{
    public class ProfileOrganizationResponseModel : ResponseModel
    {
        public ProfileOrganizationResponseModel(OrganizationUserOrganizationDetails organization)
            : base("profileOrganization")
        {
            Id = organization.OrganizationId.ToString();
            Name = organization.Name;
            UseGroups = organization.UseGroups;
            Seats = organization.Seats;
            MaxCollections = organization.MaxCollections;
            Key = organization.Key;
            Status = organization.Status;
            Type = organization.Type;
            Enabled = organization.Enabled;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public bool UseGroups { get; set; }
        public int Seats { get; set; }
        public int MaxCollections { get; set; }
        public string Key { get; set; }
        public OrganizationUserStatusType Status { get; set; }
        public OrganizationUserType Type { get; set; }
        public bool Enabled { get; set; }
    }
}
