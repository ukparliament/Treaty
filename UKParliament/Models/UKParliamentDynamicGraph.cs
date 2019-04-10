namespace UKParliament.Model
{
    using OntologyHelper;
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class UKParliamentDynamicGraph : DynamicGraph
    {
        public UKParliamentDynamicGraph(IGraph graph, Uri subjectBaseUri = null) : base(graph, subjectBaseUri) { }

        public ICollection<TemporalThing> TemporalThingCollection => new DynamicSubjectCollection<TemporalThing>("rdf:type", this[UKParliamentOntology.TemporalThing.Uri] as DynamicNode);

        public ICollection<PastThing> PastThingCollection => new DynamicSubjectCollection<PastThing>("rdf:type", this[UKParliamentOntology.PastThing.Uri] as DynamicNode);

        public ICollection<MnisThing> MnisThingCollection => new DynamicSubjectCollection<MnisThing>("rdf:type", this[UKParliamentOntology.MnisThing.Uri] as DynamicNode);

        public ICollection<DodsThing> DodsThingCollection => new DynamicSubjectCollection<DodsThing>("rdf:type", this[UKParliamentOntology.DodsThing.Uri] as DynamicNode);

        public ICollection<UkgapThing> UkgapThingCollection => new DynamicSubjectCollection<UkgapThing>("rdf:type", this[UKParliamentOntology.UkgapThing.Uri] as DynamicNode);

        public ICollection<PimsThing> PimsThingCollection => new DynamicSubjectCollection<PimsThing>("rdf:type", this[UKParliamentOntology.PimsThing.Uri] as DynamicNode);

        public ICollection<WikidataThing> WikidataThingCollection => new DynamicSubjectCollection<WikidataThing>("rdf:type", this[UKParliamentOntology.WikidataThing.Uri] as DynamicNode);

        public ICollection<WikidataResource> WikidataResourceCollection => new DynamicSubjectCollection<WikidataResource>("rdf:type", this[UKParliamentOntology.WikidataResource.Uri] as DynamicNode);

        public ICollection<ExternalThing> ExternalThingCollection => new DynamicSubjectCollection<ExternalThing>("rdf:type", this[UKParliamentOntology.ExternalThing.Uri] as DynamicNode);

        public ICollection<NamedThing> NamedThingCollection => new DynamicSubjectCollection<NamedThing>("rdf:type", this[UKParliamentOntology.NamedThing.Uri] as DynamicNode);

        public ICollection<OnsThing> OnsThingCollection => new DynamicSubjectCollection<OnsThing>("rdf:type", this[UKParliamentOntology.OnsThing.Uri] as DynamicNode);

        public ICollection<GeographicalThing> GeographicalThingCollection => new DynamicSubjectCollection<GeographicalThing>("rdf:type", this[UKParliamentOntology.GeographicalThing.Uri] as DynamicNode);

        public ICollection<ContactableThing> ContactableThingCollection => new DynamicSubjectCollection<ContactableThing>("rdf:type", this[UKParliamentOntology.ContactableThing.Uri] as DynamicNode);

        public ICollection<House> HouseCollection => new DynamicSubjectCollection<House>("rdf:type", this[UKParliamentOntology.House.Uri] as DynamicNode);

        public ICollection<HouseSeat> HouseSeatCollection => new DynamicSubjectCollection<HouseSeat>("rdf:type", this[UKParliamentOntology.HouseSeat.Uri] as DynamicNode);

        public ICollection<HouseSeatType> HouseSeatTypeCollection => new DynamicSubjectCollection<HouseSeatType>("rdf:type", this[UKParliamentOntology.HouseSeatType.Uri] as DynamicNode);

        public ICollection<MnisHouseSeatType> MnisHouseSeatTypeCollection => new DynamicSubjectCollection<MnisHouseSeatType>("rdf:type", this[UKParliamentOntology.MnisHouseSeatType.Uri] as DynamicNode);

        public ICollection<ConstituencyGroup> ConstituencyGroupCollection => new DynamicSubjectCollection<ConstituencyGroup>("rdf:type", this[UKParliamentOntology.ConstituencyGroup.Uri] as DynamicNode);

        public ICollection<ConstituencyArea> ConstituencyAreaCollection => new DynamicSubjectCollection<ConstituencyArea>("rdf:type", this[UKParliamentOntology.ConstituencyArea.Uri] as DynamicNode);

        public ICollection<Country> CountryCollection => new DynamicSubjectCollection<Country>("rdf:type", this[UKParliamentOntology.Country.Uri] as DynamicNode);

        public ICollection<MnisConstituencyGroup> MnisConstituencyGroupCollection => new DynamicSubjectCollection<MnisConstituencyGroup>("rdf:type", this[UKParliamentOntology.MnisConstituencyGroup.Uri] as DynamicNode);

        public ICollection<PastConstituencyGroup> PastConstituencyGroupCollection => new DynamicSubjectCollection<PastConstituencyGroup>("rdf:type", this[UKParliamentOntology.PastConstituencyGroup.Uri] as DynamicNode);

        public ICollection<SeatIncumbency> SeatIncumbencyCollection => new DynamicSubjectCollection<SeatIncumbency>("rdf:type", this[UKParliamentOntology.SeatIncumbency.Uri] as DynamicNode);

        public ICollection<MnisSeatIncumbency> MnisSeatIncumbencyCollection => new DynamicSubjectCollection<MnisSeatIncumbency>("rdf:type", this[UKParliamentOntology.MnisSeatIncumbency.Uri] as DynamicNode);

        public ICollection<Person> PersonCollection => new DynamicSubjectCollection<Person>("rdf:type", this[UKParliamentOntology.Person.Uri] as DynamicNode);

        public ICollection<MnisFormalBodyLayPerson> MnisFormalBodyLayPersonCollection => new DynamicSubjectCollection<MnisFormalBodyLayPerson>("rdf:type", this[UKParliamentOntology.MnisFormalBodyLayPerson.Uri] as DynamicNode);

        public ICollection<DodsPerson> DodsPersonCollection => new DynamicSubjectCollection<DodsPerson>("rdf:type", this[UKParliamentOntology.DodsPerson.Uri] as DynamicNode);

        public ICollection<PimsPerson> PimsPersonCollection => new DynamicSubjectCollection<PimsPerson>("rdf:type", this[UKParliamentOntology.PimsPerson.Uri] as DynamicNode);

        public ICollection<DeceasedPerson> DeceasedPersonCollection => new DynamicSubjectCollection<DeceasedPerson>("rdf:type", this[UKParliamentOntology.DeceasedPerson.Uri] as DynamicNode);

        public ICollection<Member> MemberCollection => new DynamicSubjectCollection<Member>("rdf:type", this[UKParliamentOntology.Member.Uri] as DynamicNode);

        public ICollection<MnisMember> MnisMemberCollection => new DynamicSubjectCollection<MnisMember>("rdf:type", this[UKParliamentOntology.MnisMember.Uri] as DynamicNode);

        public ICollection<Gender> GenderCollection => new DynamicSubjectCollection<Gender>("rdf:type", this[UKParliamentOntology.Gender.Uri] as DynamicNode);

        public ICollection<MnisGender> MnisGenderCollection => new DynamicSubjectCollection<MnisGender>("rdf:type", this[UKParliamentOntology.MnisGender.Uri] as DynamicNode);

        public ICollection<GenderIdentity> GenderIdentityCollection => new DynamicSubjectCollection<GenderIdentity>("rdf:type", this[UKParliamentOntology.GenderIdentity.Uri] as DynamicNode);

        public ICollection<ContactPoint> ContactPointCollection => new DynamicSubjectCollection<ContactPoint>("rdf:type", this[UKParliamentOntology.ContactPoint.Uri] as DynamicNode);

        public ICollection<MnisContactPoint> MnisContactPointCollection => new DynamicSubjectCollection<MnisContactPoint>("rdf:type", this[UKParliamentOntology.MnisContactPoint.Uri] as DynamicNode);

        public ICollection<PostalAddress> PostalAddressCollection => new DynamicSubjectCollection<PostalAddress>("rdf:type", this[UKParliamentOntology.PostalAddress.Uri] as DynamicNode);

        public ICollection<Candidate> CandidateCollection => new DynamicSubjectCollection<Candidate>("rdf:type", this[UKParliamentOntology.Candidate.Uri] as DynamicNode);

        public ICollection<Candidacy> CandidacyCollection => new DynamicSubjectCollection<Candidacy>("rdf:type", this[UKParliamentOntology.Candidacy.Uri] as DynamicNode);

        public ICollection<CandidacyResult> CandidacyResultCollection => new DynamicSubjectCollection<CandidacyResult>("rdf:type", this[UKParliamentOntology.CandidacyResult.Uri] as DynamicNode);

        public ICollection<Party> PartyCollection => new DynamicSubjectCollection<Party>("rdf:type", this[UKParliamentOntology.Party.Uri] as DynamicNode);

        public ICollection<MnisParty> MnisPartyCollection => new DynamicSubjectCollection<MnisParty>("rdf:type", this[UKParliamentOntology.MnisParty.Uri] as DynamicNode);

        public ICollection<PartyMember> PartyMemberCollection => new DynamicSubjectCollection<PartyMember>("rdf:type", this[UKParliamentOntology.PartyMember.Uri] as DynamicNode);

        public ICollection<PartyMembership> PartyMembershipCollection => new DynamicSubjectCollection<PartyMembership>("rdf:type", this[UKParliamentOntology.PartyMembership.Uri] as DynamicNode);

        public ICollection<MnisPartyMembership> MnisPartyMembershipCollection => new DynamicSubjectCollection<MnisPartyMembership>("rdf:type", this[UKParliamentOntology.MnisPartyMembership.Uri] as DynamicNode);

        public ICollection<PastPartyMembership> PastPartyMembershipCollection => new DynamicSubjectCollection<PastPartyMembership>("rdf:type", this[UKParliamentOntology.PastPartyMembership.Uri] as DynamicNode);

        public ICollection<Election> ElectionCollection => new DynamicSubjectCollection<Election>("rdf:type", this[UKParliamentOntology.Election.Uri] as DynamicNode);

        public ICollection<ElectionType> ElectionTypeCollection => new DynamicSubjectCollection<ElectionType>("rdf:type", this[UKParliamentOntology.ElectionType.Uri] as DynamicNode);

        public ICollection<MnisElectionType> MnisElectionTypeCollection => new DynamicSubjectCollection<MnisElectionType>("rdf:type", this[UKParliamentOntology.MnisElectionType.Uri] as DynamicNode);

        public ICollection<Electorate> ElectorateCollection => new DynamicSubjectCollection<Electorate>("rdf:type", this[UKParliamentOntology.Electorate.Uri] as DynamicNode);

        public ICollection<ElectoralIncumbency> ElectoralIncumbencyCollection => new DynamicSubjectCollection<ElectoralIncumbency>("rdf:type", this[UKParliamentOntology.ElectoralIncumbency.Uri] as DynamicNode);

        public ICollection<ParliamentPeriod> ParliamentPeriodCollection => new DynamicSubjectCollection<ParliamentPeriod>("rdf:type", this[UKParliamentOntology.ParliamentPeriod.Uri] as DynamicNode);

        public ICollection<PastParliamentPeriod> PastParliamentPeriodCollection => new DynamicSubjectCollection<PastParliamentPeriod>("rdf:type", this[UKParliamentOntology.PastParliamentPeriod.Uri] as DynamicNode);

        public ICollection<OnsConstituencyGroup> OnsConstituencyGroupCollection => new DynamicSubjectCollection<OnsConstituencyGroup>("rdf:type", this[UKParliamentOntology.OnsConstituencyGroup.Uri] as DynamicNode);

        public ICollection<Position> PositionCollection => new DynamicSubjectCollection<Position>("rdf:type", this[UKParliamentOntology.Position.Uri] as DynamicNode);

        public ICollection<ParliamentaryIncumbency> ParliamentaryIncumbencyCollection => new DynamicSubjectCollection<ParliamentaryIncumbency>("rdf:type", this[UKParliamentOntology.ParliamentaryIncumbency.Uri] as DynamicNode);

        public ICollection<Incumbency> IncumbencyCollection => new DynamicSubjectCollection<Incumbency>("rdf:type", this[UKParliamentOntology.Incumbency.Uri] as DynamicNode);

        public ICollection<MnisFormalBodyChairIncumbency> MnisFormalBodyChairIncumbencyCollection => new DynamicSubjectCollection<MnisFormalBodyChairIncumbency>("rdf:type", this[UKParliamentOntology.MnisFormalBodyChairIncumbency.Uri] as DynamicNode);

        public ICollection<PastIncumbency> PastIncumbencyCollection => new DynamicSubjectCollection<PastIncumbency>("rdf:type", this[UKParliamentOntology.PastIncumbency.Uri] as DynamicNode);

        public ICollection<PastParliamentaryIncumbency> PastParliamentaryIncumbencyCollection => new DynamicSubjectCollection<PastParliamentaryIncumbency>("rdf:type", this[UKParliamentOntology.PastParliamentaryIncumbency.Uri] as DynamicNode);

        public ICollection<EPetition> EPetitionCollection => new DynamicSubjectCollection<EPetition>("rdf:type", this[UKParliamentOntology.EPetition.Uri] as DynamicNode);

        public ICollection<RejectedEPetition> RejectedEPetitionCollection => new DynamicSubjectCollection<RejectedEPetition>("rdf:type", this[UKParliamentOntology.RejectedEPetition.Uri] as DynamicNode);

        public ICollection<ApprovedEPetition> ApprovedEPetitionCollection => new DynamicSubjectCollection<ApprovedEPetition>("rdf:type", this[UKParliamentOntology.ApprovedEPetition.Uri] as DynamicNode);

        public ICollection<UkgapEPetition> UkgapEPetitionCollection => new DynamicSubjectCollection<UkgapEPetition>("rdf:type", this[UKParliamentOntology.UkgapEPetition.Uri] as DynamicNode);

        public ICollection<ThresholdAttainment> ThresholdAttainmentCollection => new DynamicSubjectCollection<ThresholdAttainment>("rdf:type", this[UKParliamentOntology.ThresholdAttainment.Uri] as DynamicNode);

        public ICollection<Threshold> ThresholdCollection => new DynamicSubjectCollection<Threshold>("rdf:type", this[UKParliamentOntology.Threshold.Uri] as DynamicNode);

        public ICollection<Moderation> ModerationCollection => new DynamicSubjectCollection<Moderation>("rdf:type", this[UKParliamentOntology.Moderation.Uri] as DynamicNode);

        public ICollection<Debate> DebateCollection => new DynamicSubjectCollection<Debate>("rdf:type", this[UKParliamentOntology.Debate.Uri] as DynamicNode);

        public ICollection<GovernmentResponse> GovernmentResponseCollection => new DynamicSubjectCollection<GovernmentResponse>("rdf:type", this[UKParliamentOntology.GovernmentResponse.Uri] as DynamicNode);

        public ICollection<LocatedSignatureCount> LocatedSignatureCountCollection => new DynamicSubjectCollection<LocatedSignatureCount>("rdf:type", this[UKParliamentOntology.LocatedSignatureCount.Uri] as DynamicNode);

        public ICollection<Place> PlaceCollection => new DynamicSubjectCollection<Place>("rdf:type", this[UKParliamentOntology.Place.Uri] as DynamicNode);

        public ICollection<Rejection> RejectionCollection => new DynamicSubjectCollection<Rejection>("rdf:type", this[UKParliamentOntology.Rejection.Uri] as DynamicNode);

        public ICollection<RejectionCode> RejectionCodeCollection => new DynamicSubjectCollection<RejectionCode>("rdf:type", this[UKParliamentOntology.RejectionCode.Uri] as DynamicNode);

        public ICollection<Approval> ApprovalCollection => new DynamicSubjectCollection<Approval>("rdf:type", this[UKParliamentOntology.Approval.Uri] as DynamicNode);

        public ICollection<ConceptualisedThing> ConceptualisedThingCollection => new DynamicSubjectCollection<ConceptualisedThing>("rdf:type", this[UKParliamentOntology.ConceptualisedThing.Uri] as DynamicNode);

        public ICollection<SubjectTaggedThing> SubjectTaggedThingCollection => new DynamicSubjectCollection<SubjectTaggedThing>("rdf:type", this[UKParliamentOntology.SubjectTaggedThing.Uri] as DynamicNode);

        public ICollection<Concept> ConceptCollection => new DynamicSubjectCollection<Concept>("rdf:type", this[UKParliamentOntology.Concept.Uri] as DynamicNode);

        public ICollection<GovRegisterThing> GovRegisterThingCollection => new DynamicSubjectCollection<GovRegisterThing>("rdf:type", this[UKParliamentOntology.GovRegisterThing.Uri] as DynamicNode);

        public ICollection<GovRegisterCountry> GovRegisterCountryCollection => new DynamicSubjectCollection<GovRegisterCountry>("rdf:type", this[UKParliamentOntology.GovRegisterCountry.Uri] as DynamicNode);

        public ICollection<GovRegisterTerritory> GovRegisterTerritoryCollection => new DynamicSubjectCollection<GovRegisterTerritory>("rdf:type", this[UKParliamentOntology.GovRegisterTerritory.Uri] as DynamicNode);

        public ICollection<Territory> TerritoryCollection => new DynamicSubjectCollection<Territory>("rdf:type", this[UKParliamentOntology.Territory.Uri] as DynamicNode);

        public ICollection<Image> ImageCollection => new DynamicSubjectCollection<Image>("rdf:type", this[UKParliamentOntology.Image.Uri] as DynamicNode);

        public ICollection<PersonImage> PersonImageCollection => new DynamicSubjectCollection<PersonImage>("rdf:type", this[UKParliamentOntology.PersonImage.Uri] as DynamicNode);

        public ICollection<MemberImage> MemberImageCollection => new DynamicSubjectCollection<MemberImage>("rdf:type", this[UKParliamentOntology.MemberImage.Uri] as DynamicNode);

        public ICollection<Logo> LogoCollection => new DynamicSubjectCollection<Logo>("rdf:type", this[UKParliamentOntology.Logo.Uri] as DynamicNode);

        public ICollection<LogoImage> LogoImageCollection => new DynamicSubjectCollection<LogoImage>("rdf:type", this[UKParliamentOntology.LogoImage.Uri] as DynamicNode);

        public ICollection<ThingWithLogo> ThingWithLogoCollection => new DynamicSubjectCollection<ThingWithLogo>("rdf:type", this[UKParliamentOntology.ThingWithLogo.Uri] as DynamicNode);

        public ICollection<ImageSubject> ImageSubjectCollection => new DynamicSubjectCollection<ImageSubject>("rdf:type", this[UKParliamentOntology.ImageSubject.Uri] as DynamicNode);

        public ICollection<WebLink> WebLinkCollection => new DynamicSubjectCollection<WebLink>("rdf:type", this[UKParliamentOntology.WebLink.Uri] as DynamicNode);

        public ICollection<WebLinkedThing> WebLinkedThingCollection => new DynamicSubjectCollection<WebLinkedThing>("rdf:type", this[UKParliamentOntology.WebLinkedThing.Uri] as DynamicNode);

        public ICollection<PersonWebLink> PersonWebLinkCollection => new DynamicSubjectCollection<PersonWebLink>("rdf:type", this[UKParliamentOntology.PersonWebLink.Uri] as DynamicNode);

        public ICollection<BusinessItemWebLink> BusinessItemWebLinkCollection => new DynamicSubjectCollection<BusinessItemWebLink>("rdf:type", this[UKParliamentOntology.BusinessItemWebLink.Uri] as DynamicNode);

        public ICollection<WorkPackagedThingWebLink> WorkPackagedThingWebLinkCollection => new DynamicSubjectCollection<WorkPackagedThingWebLink>("rdf:type", this[UKParliamentOntology.WorkPackagedThingWebLink.Uri] as DynamicNode);

        public ICollection<Group> GroupCollection => new DynamicSubjectCollection<Group>("rdf:type", this[UKParliamentOntology.Group.Uri] as DynamicNode);

        public ICollection<PastGroup> PastGroupCollection => new DynamicSubjectCollection<PastGroup>("rdf:type", this[UKParliamentOntology.PastGroup.Uri] as DynamicNode);

        public ICollection<MnisDepartmentGroup> MnisDepartmentGroupCollection => new DynamicSubjectCollection<MnisDepartmentGroup>("rdf:type", this[UKParliamentOntology.MnisDepartmentGroup.Uri] as DynamicNode);

        public ICollection<FormalBody> FormalBodyCollection => new DynamicSubjectCollection<FormalBody>("rdf:type", this[UKParliamentOntology.FormalBody.Uri] as DynamicNode);

        public ICollection<StatutoryCommittee> StatutoryCommitteeCollection => new DynamicSubjectCollection<StatutoryCommittee>("rdf:type", this[UKParliamentOntology.StatutoryCommittee.Uri] as DynamicNode);

        public ICollection<InformallyConstitutedCommittee> InformallyConstitutedCommitteeCollection => new DynamicSubjectCollection<InformallyConstitutedCommittee>("rdf:type", this[UKParliamentOntology.InformallyConstitutedCommittee.Uri] as DynamicNode);

        public ICollection<ParliamentaryCommittee> ParliamentaryCommitteeCollection => new DynamicSubjectCollection<ParliamentaryCommittee>("rdf:type", this[UKParliamentOntology.ParliamentaryCommittee.Uri] as DynamicNode);

        public ICollection<SelectCommittee> SelectCommitteeCollection => new DynamicSubjectCollection<SelectCommittee>("rdf:type", this[UKParliamentOntology.SelectCommittee.Uri] as DynamicNode);

        public ICollection<NonSelectCommittee> NonSelectCommitteeCollection => new DynamicSubjectCollection<NonSelectCommittee>("rdf:type", this[UKParliamentOntology.NonSelectCommittee.Uri] as DynamicNode);

        public ICollection<GeneralCommittee> GeneralCommitteeCollection => new DynamicSubjectCollection<GeneralCommittee>("rdf:type", this[UKParliamentOntology.GeneralCommittee.Uri] as DynamicNode);

        public ICollection<PastFormalBody> PastFormalBodyCollection => new DynamicSubjectCollection<PastFormalBody>("rdf:type", this[UKParliamentOntology.PastFormalBody.Uri] as DynamicNode);

        public ICollection<PastFormalBodyMembership> PastFormalBodyMembershipCollection => new DynamicSubjectCollection<PastFormalBodyMembership>("rdf:type", this[UKParliamentOntology.PastFormalBodyMembership.Uri] as DynamicNode);

        public ICollection<MnisFormalBody> MnisFormalBodyCollection => new DynamicSubjectCollection<MnisFormalBody>("rdf:type", this[UKParliamentOntology.MnisFormalBody.Uri] as DynamicNode);

        public ICollection<MnisFormalBodyMembership> MnisFormalBodyMembershipCollection => new DynamicSubjectCollection<MnisFormalBodyMembership>("rdf:type", this[UKParliamentOntology.MnisFormalBodyMembership.Uri] as DynamicNode);

        public ICollection<FormalBodyMembership> FormalBodyMembershipCollection => new DynamicSubjectCollection<FormalBodyMembership>("rdf:type", this[UKParliamentOntology.FormalBodyMembership.Uri] as DynamicNode);

        public ICollection<ExOfficioMembership> ExOfficioMembershipCollection => new DynamicSubjectCollection<ExOfficioMembership>("rdf:type", this[UKParliamentOntology.ExOfficioMembership.Uri] as DynamicNode);

        public ICollection<AlternateMembership> AlternateMembershipCollection => new DynamicSubjectCollection<AlternateMembership>("rdf:type", this[UKParliamentOntology.AlternateMembership.Uri] as DynamicNode);

        public ICollection<FormalBodyPosition> FormalBodyPositionCollection => new DynamicSubjectCollection<FormalBodyPosition>("rdf:type", this[UKParliamentOntology.FormalBodyPosition.Uri] as DynamicNode);

        public ICollection<FormalBodyChair> FormalBodyChairCollection => new DynamicSubjectCollection<FormalBodyChair>("rdf:type", this[UKParliamentOntology.FormalBodyChair.Uri] as DynamicNode);

        public ICollection<GovernmentPosition> GovernmentPositionCollection => new DynamicSubjectCollection<GovernmentPosition>("rdf:type", this[UKParliamentOntology.GovernmentPosition.Uri] as DynamicNode);

        public ICollection<MnisGovernmentPosition> MnisGovernmentPositionCollection => new DynamicSubjectCollection<MnisGovernmentPosition>("rdf:type", this[UKParliamentOntology.MnisGovernmentPosition.Uri] as DynamicNode);

        public ICollection<GovRegisterGovernmentOrganisation> GovRegisterGovernmentOrganisationCollection => new DynamicSubjectCollection<GovRegisterGovernmentOrganisation>("rdf:type", this[UKParliamentOntology.GovRegisterGovernmentOrganisation.Uri] as DynamicNode);

        public ICollection<GovernmentOrganisation> GovernmentOrganisationCollection => new DynamicSubjectCollection<GovernmentOrganisation>("rdf:type", this[UKParliamentOntology.GovernmentOrganisation.Uri] as DynamicNode);

        public ICollection<GovernmentIncumbency> GovernmentIncumbencyCollection => new DynamicSubjectCollection<GovernmentIncumbency>("rdf:type", this[UKParliamentOntology.GovernmentIncumbency.Uri] as DynamicNode);

        public ICollection<MnisGovernmentIncumbency> MnisGovernmentIncumbencyCollection => new DynamicSubjectCollection<MnisGovernmentIncumbency>("rdf:type", this[UKParliamentOntology.MnisGovernmentIncumbency.Uri] as DynamicNode);

        public ICollection<GovernmentPerson> GovernmentPersonCollection => new DynamicSubjectCollection<GovernmentPerson>("rdf:type", this[UKParliamentOntology.GovernmentPerson.Uri] as DynamicNode);

        public ICollection<OppositionPosition> OppositionPositionCollection => new DynamicSubjectCollection<OppositionPosition>("rdf:type", this[UKParliamentOntology.OppositionPosition.Uri] as DynamicNode);

        public ICollection<MnisOppositionPosition> MnisOppositionPositionCollection => new DynamicSubjectCollection<MnisOppositionPosition>("rdf:type", this[UKParliamentOntology.MnisOppositionPosition.Uri] as DynamicNode);

        public ICollection<OppositionIncumbency> OppositionIncumbencyCollection => new DynamicSubjectCollection<OppositionIncumbency>("rdf:type", this[UKParliamentOntology.OppositionIncumbency.Uri] as DynamicNode);

        public ICollection<MnisOppositionIncumbency> MnisOppositionIncumbencyCollection => new DynamicSubjectCollection<MnisOppositionIncumbency>("rdf:type", this[UKParliamentOntology.MnisOppositionIncumbency.Uri] as DynamicNode);

        public ICollection<OppositionPerson> OppositionPersonCollection => new DynamicSubjectCollection<OppositionPerson>("rdf:type", this[UKParliamentOntology.OppositionPerson.Uri] as DynamicNode);

        public ICollection<SesThing> SesThingCollection => new DynamicSubjectCollection<SesThing>("rdf:type", this[UKParliamentOntology.SesThing.Uri] as DynamicNode);

        public ICollection<FocusPeriod> FocusPeriodCollection => new DynamicSubjectCollection<FocusPeriod>("rdf:type", this[UKParliamentOntology.FocusPeriod.Uri] as DynamicNode);

        public ICollection<Focus> FocusCollection => new DynamicSubjectCollection<Focus>("rdf:type", this[UKParliamentOntology.Focus.Uri] as DynamicNode);

        public ICollection<FormalBodyType> FormalBodyTypeCollection => new DynamicSubjectCollection<FormalBodyType>("rdf:type", this[UKParliamentOntology.FormalBodyType.Uri] as DynamicNode);

        public ICollection<Question> QuestionCollection => new DynamicSubjectCollection<Question>("rdf:type", this[UKParliamentOntology.Question.Uri] as DynamicNode);

        public ICollection<IndexingAndSearchWrittenQuestion> IndexingAndSearchWrittenQuestionCollection => new DynamicSubjectCollection<IndexingAndSearchWrittenQuestion>("rdf:type", this[UKParliamentOntology.IndexingAndSearchWrittenQuestion.Uri] as DynamicNode);

        public ICollection<IndexingAndSearchThing> IndexingAndSearchThingCollection => new DynamicSubjectCollection<IndexingAndSearchThing>("rdf:type", this[UKParliamentOntology.IndexingAndSearchThing.Uri] as DynamicNode);

        public ICollection<AnswerExpectation> AnswerExpectationCollection => new DynamicSubjectCollection<AnswerExpectation>("rdf:type", this[UKParliamentOntology.AnswerExpectation.Uri] as DynamicNode);

        public ICollection<OralAnswerExpectation> OralAnswerExpectationCollection => new DynamicSubjectCollection<OralAnswerExpectation>("rdf:type", this[UKParliamentOntology.OralAnswerExpectation.Uri] as DynamicNode);

        public ICollection<WrittenAnswerExpectation> WrittenAnswerExpectationCollection => new DynamicSubjectCollection<WrittenAnswerExpectation>("rdf:type", this[UKParliamentOntology.WrittenAnswerExpectation.Uri] as DynamicNode);

        public ICollection<Answer> AnswerCollection => new DynamicSubjectCollection<Answer>("rdf:type", this[UKParliamentOntology.Answer.Uri] as DynamicNode);

        public ICollection<CorrectingAnswer> CorrectingAnswerCollection => new DynamicSubjectCollection<CorrectingAnswer>("rdf:type", this[UKParliamentOntology.CorrectingAnswer.Uri] as DynamicNode);

        public ICollection<SinceCorrectedAnswer> SinceCorrectedAnswerCollection => new DynamicSubjectCollection<SinceCorrectedAnswer>("rdf:type", this[UKParliamentOntology.SinceCorrectedAnswer.Uri] as DynamicNode);

        public ICollection<ProrogationAnswer> ProrogationAnswerCollection => new DynamicSubjectCollection<ProrogationAnswer>("rdf:type", this[UKParliamentOntology.ProrogationAnswer.Uri] as DynamicNode);

        public ICollection<SubstantiveAnswer> SubstantiveAnswerCollection => new DynamicSubjectCollection<SubstantiveAnswer>("rdf:type", this[UKParliamentOntology.SubstantiveAnswer.Uri] as DynamicNode);

        public ICollection<DelegatedAnswer> DelegatedAnswerCollection => new DynamicSubjectCollection<DelegatedAnswer>("rdf:type", this[UKParliamentOntology.DelegatedAnswer.Uri] as DynamicNode);

        public ICollection<HoldingAnswer> HoldingAnswerCollection => new DynamicSubjectCollection<HoldingAnswer>("rdf:type", this[UKParliamentOntology.HoldingAnswer.Uri] as DynamicNode);

        public ICollection<OralAnswer> OralAnswerCollection => new DynamicSubjectCollection<OralAnswer>("rdf:type", this[UKParliamentOntology.OralAnswer.Uri] as DynamicNode);

        public ICollection<WrittenAnswer> WrittenAnswerCollection => new DynamicSubjectCollection<WrittenAnswer>("rdf:type", this[UKParliamentOntology.WrittenAnswer.Uri] as DynamicNode);

        public ICollection<AnsweringBodyAllocation> AnsweringBodyAllocationCollection => new DynamicSubjectCollection<AnsweringBodyAllocation>("rdf:type", this[UKParliamentOntology.AnsweringBodyAllocation.Uri] as DynamicNode);

        public ICollection<AnsweringBody> AnsweringBodyCollection => new DynamicSubjectCollection<AnsweringBody>("rdf:type", this[UKParliamentOntology.AnsweringBody.Uri] as DynamicNode);

        public ICollection<ArmsLengthBody> ArmsLengthBodyCollection => new DynamicSubjectCollection<ArmsLengthBody>("rdf:type", this[UKParliamentOntology.ArmsLengthBody.Uri] as DynamicNode);

        public ICollection<MnisAnsweringBody> MnisAnsweringBodyCollection => new DynamicSubjectCollection<MnisAnsweringBody>("rdf:type", this[UKParliamentOntology.MnisAnsweringBody.Uri] as DynamicNode);

        public ICollection<ParliamentaryQuestion> ParliamentaryQuestionCollection => new DynamicSubjectCollection<ParliamentaryQuestion>("rdf:type", this[UKParliamentOntology.ParliamentaryQuestion.Uri] as DynamicNode);

        public ICollection<RoundRobin> RoundRobinCollection => new DynamicSubjectCollection<RoundRobin>("rdf:type", this[UKParliamentOntology.RoundRobin.Uri] as DynamicNode);

        public ICollection<PursuedThing> PursuedThingCollection => new DynamicSubjectCollection<PursuedThing>("rdf:type", this[UKParliamentOntology.PursuedThing.Uri] as DynamicNode);

        public ICollection<IncumbencyInterruption> IncumbencyInterruptionCollection => new DynamicSubjectCollection<IncumbencyInterruption>("rdf:type", this[UKParliamentOntology.IncumbencyInterruption.Uri] as DynamicNode);

        public ICollection<PastIncumbencyInterruption> PastIncumbencyInterruptionCollection => new DynamicSubjectCollection<PastIncumbencyInterruption>("rdf:type", this[UKParliamentOntology.PastIncumbencyInterruption.Uri] as DynamicNode);

        public ICollection<WorkPackage> WorkPackageCollection => new DynamicSubjectCollection<WorkPackage>("rdf:type", this[UKParliamentOntology.WorkPackage.Uri] as DynamicNode);

        public ICollection<Procedure> ProcedureCollection => new DynamicSubjectCollection<Procedure>("rdf:type", this[UKParliamentOntology.Procedure.Uri] as DynamicNode);

        public ICollection<ProcedureStep> ProcedureStepCollection => new DynamicSubjectCollection<ProcedureStep>("rdf:type", this[UKParliamentOntology.ProcedureStep.Uri] as DynamicNode);

        public ICollection<ProcedureStepPublication> ProcedureStepPublicationCollection => new DynamicSubjectCollection<ProcedureStepPublication>("rdf:type", this[UKParliamentOntology.ProcedureStepPublication.Uri] as DynamicNode);

        public ICollection<BusinessItem> BusinessItemCollection => new DynamicSubjectCollection<BusinessItem>("rdf:type", this[UKParliamentOntology.BusinessItem.Uri] as DynamicNode);

        public ICollection<ProcedureRoute> ProcedureRouteCollection => new DynamicSubjectCollection<ProcedureRoute>("rdf:type", this[UKParliamentOntology.ProcedureRoute.Uri] as DynamicNode);

        public ICollection<AllowedProcedureRoute> AllowedProcedureRouteCollection => new DynamicSubjectCollection<AllowedProcedureRoute>("rdf:type", this[UKParliamentOntology.AllowedProcedureRoute.Uri] as DynamicNode);

        public ICollection<RequiredProcedureRoute> RequiredProcedureRouteCollection => new DynamicSubjectCollection<RequiredProcedureRoute>("rdf:type", this[UKParliamentOntology.RequiredProcedureRoute.Uri] as DynamicNode);

        public ICollection<CausedProcedureRoute> CausedProcedureRouteCollection => new DynamicSubjectCollection<CausedProcedureRoute>("rdf:type", this[UKParliamentOntology.CausedProcedureRoute.Uri] as DynamicNode);

        public ICollection<PrecludedProcedureRoute> PrecludedProcedureRouteCollection => new DynamicSubjectCollection<PrecludedProcedureRoute>("rdf:type", this[UKParliamentOntology.PrecludedProcedureRoute.Uri] as DynamicNode);

        public ICollection<Laying> LayingCollection => new DynamicSubjectCollection<Laying>("rdf:type", this[UKParliamentOntology.Laying.Uri] as DynamicNode);

        public ICollection<Withdrawal> WithdrawalCollection => new DynamicSubjectCollection<Withdrawal>("rdf:type", this[UKParliamentOntology.Withdrawal.Uri] as DynamicNode);

        public ICollection<WorkPackagedThing> WorkPackagedThingCollection => new DynamicSubjectCollection<WorkPackagedThing>("rdf:type", this[UKParliamentOntology.WorkPackagedThing.Uri] as DynamicNode);

        public ICollection<LaidThing> LaidThingCollection => new DynamicSubjectCollection<LaidThing>("rdf:type", this[UKParliamentOntology.LaidThing.Uri] as DynamicNode);

        public ICollection<WithdrawnThing> WithdrawnThingCollection => new DynamicSubjectCollection<WithdrawnThing>("rdf:type", this[UKParliamentOntology.WithdrawnThing.Uri] as DynamicNode);

        public ICollection<StatutoryInstrumentPaper> StatutoryInstrumentPaperCollection => new DynamicSubjectCollection<StatutoryInstrumentPaper>("rdf:type", this[UKParliamentOntology.StatutoryInstrumentPaper.Uri] as DynamicNode);

        public ICollection<Treaty> TreatyCollection => new DynamicSubjectCollection<Treaty>("rdf:type", this[UKParliamentOntology.Treaty.Uri] as DynamicNode);

        public ICollection<InForceTreaty> InForceTreatyCollection => new DynamicSubjectCollection<InForceTreaty>("rdf:type", this[UKParliamentOntology.InForceTreaty.Uri] as DynamicNode);

        public ICollection<SeriesMembership> SeriesMembershipCollection => new DynamicSubjectCollection<SeriesMembership>("rdf:type", this[UKParliamentOntology.SeriesMembership.Uri] as DynamicNode);

        public ICollection<TreatySeriesMembership> TreatySeriesMembershipCollection => new DynamicSubjectCollection<TreatySeriesMembership>("rdf:type", this[UKParliamentOntology.TreatySeriesMembership.Uri] as DynamicNode);

        public ICollection<CountrySeriesMembership> CountrySeriesMembershipCollection => new DynamicSubjectCollection<CountrySeriesMembership>("rdf:type", this[UKParliamentOntology.CountrySeriesMembership.Uri] as DynamicNode);

        public ICollection<EuropeanUnionSeriesMembership> EuropeanUnionSeriesMembershipCollection => new DynamicSubjectCollection<EuropeanUnionSeriesMembership>("rdf:type", this[UKParliamentOntology.EuropeanUnionSeriesMembership.Uri] as DynamicNode);

        public ICollection<MiscellaneousSeriesMembership> MiscellaneousSeriesMembershipCollection => new DynamicSubjectCollection<MiscellaneousSeriesMembership>("rdf:type", this[UKParliamentOntology.MiscellaneousSeriesMembership.Uri] as DynamicNode);

        public ICollection<ProposedNegativeStatutoryInstrumentPaper> ProposedNegativeStatutoryInstrumentPaperCollection => new DynamicSubjectCollection<ProposedNegativeStatutoryInstrumentPaper>("rdf:type", this[UKParliamentOntology.ProposedNegativeStatutoryInstrumentPaper.Uri] as DynamicNode);

        public ICollection<MadeStatutoryInstrumentPaper> MadeStatutoryInstrumentPaperCollection => new DynamicSubjectCollection<MadeStatutoryInstrumentPaper>("rdf:type", this[UKParliamentOntology.MadeStatutoryInstrumentPaper.Uri] as DynamicNode);

        public ICollection<LayingBody> LayingBodyCollection => new DynamicSubjectCollection<LayingBody>("rdf:type", this[UKParliamentOntology.LayingBody.Uri] as DynamicNode);

        public ICollection<LayingPerson> LayingPersonCollection => new DynamicSubjectCollection<LayingPerson>("rdf:type", this[UKParliamentOntology.LayingPerson.Uri] as DynamicNode);

        public ICollection<WebsiteLabelledThing> WebsiteLabelledThingCollection => new DynamicSubjectCollection<WebsiteLabelledThing>("rdf:type", this[UKParliamentOntology.WebsiteLabelledThing.Uri] as DynamicNode);

        public ICollection<WebsiteDescribedThing> WebsiteDescribedThingCollection => new DynamicSubjectCollection<WebsiteDescribedThing>("rdf:type", this[UKParliamentOntology.WebsiteDescribedThing.Uri] as DynamicNode);
    }
}
