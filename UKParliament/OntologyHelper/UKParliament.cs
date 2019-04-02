// MIT License
//
// Copyright (c) 2019 UK Parliament
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace OntologyHelper
{
    /// <summary>
    /// Static Helper class for the UK Parliament Ontology
    /// </summary>
    public static class UKParliamentOntology
    {
        /// <summary>
        /// Base URI for things in the UK Parliament Knowledge Graph
        /// </summary>
        public const string Base = "https://id.parliament.uk/";

        /// <summary>
        /// UK Parliament namespace URI
        /// </summary>
        public const string Namespace = Base + "schema/";

        /// <summary>
        /// Constant URIs for classes in the UK Parliament Ontology
        /// </summary>
        public const string
            AllowedProcedureRoute = Namespace + "AllowedProcedureRoute",
            AlternateMembership = Namespace + "AlternateMembership",
            Answer = Namespace + "Answer",
            AnswerExpectation = Namespace + "AnswerExpectation",
            AnsweringBody = Namespace + "AnsweringBody",
            AnsweringBodyAllocation = Namespace + "AnsweringBodyAllocation",
            Approval = Namespace + "Approval",
            ApprovedEPetition = Namespace + "ApprovedEPetition",
            ArmsLengthBody = Namespace + "ArmsLengthBody",
            BusinessItem = Namespace + "BusinessItem",
            BusinessItemWebLink = Namespace + "BusinessItemWebLink",
            Candidacy = Namespace + "Candidacy",
            CandidacyResult= Namespace + "CandidacyResult",
            Candidate = Namespace + "Candidate",
            CausedProcedureRoute = Namespace + "CausedProcedureRoute",
            Concept = Namespace + "Concept",
            ConceptualisedThing = Namespace + "ConceptualisedThing",
            ConstituencyArea = Namespace + "ConstituencyArea",
            ConstituencyGroup = Namespace + "ConstituencyGroup",
            ContactableThing = Namespace + "ContactableThing",
            ContactPoint = Namespace + "ContactPoint",
            CorrectingAnswer = Namespace + "CorrectingAnswer",
            Country = Namespace + "Country",
            CountrySeriesMembership = Namespace + "CountrySeriesMembership",
            Debate = Namespace + "Debate",
            DeceasedPerson = Namespace + "DeceasedPerson",
            DelegatedAnswer = Namespace + "DelegatedAnswer",
            DodsPerson = Namespace + "DodsPerson",
            DodsThing = Namespace + "DodsThing",
            Election = Namespace + "Election",
            ElectionType = Namespace + "ElectionType",
            Electorate = Namespace + "Electorate",
            ElectoralIncumbency = Namespace + "ElectoralIncumbency",
            EPetition = Namespace + "EPetition",
            EuropeanUnionSeriesMembership = Namespace + "EuropeanUnionSeriesMembership",
            ExOfficioMembership = Namespace + "ExOfficioMembership",
            ExternalThing = Namespace + "ExternalThing",
            Focus = Namespace + "Focus",
            FocusPeriod = Namespace + "FocusPeriod",
            FormalBody = Namespace + "FormalBody",
            FormalBodyChair = Namespace + "FormalBodyChair",
            FormalBodyMembership = Namespace + "FormalBodyMembership",
            FormalBodyPosition = Namespace + "FormalBodyPosition",
            FormalBodyType = Namespace + "FormalBodyType",
            Gender = Namespace + "Gender",
            GenderIdentity = Namespace + "GenderIdentity",
            GeneralCommittee = Namespace + "GeneralCommittee",
            GeographicalThing = Namespace + "GeographicalThing",
            GovernmentIncumbency = Namespace + "GovernmentIncumbency",
            GovernmentOrganisation = Namespace + "GovernmentOrganisation",
            GovernmentPerson = Namespace + "GovernmentPerson",
            GovernmentPosition = Namespace + "GovernmentPosition",
            GovernmentResponse = Namespace + "GovernmentResponse",
            GovRegisterCountry = Namespace + "GovRegisterCountry",
            GovRegisterGovernmentOrganisation = Namespace + "GovRegisterGovernmentOrganisation",
            GovRegisterTerritory = Namespace + "GovRegisterTerritory",
            GovRegisterThing = Namespace + "GovRegisterThing",
            Group = Namespace + "Group",
            HoldingAnswer = Namespace + "HoldingAnswer",
            House = Namespace + "House",
            HouseSeat = Namespace + "HouseSeat",
            HouseSeatType = Namespace + "HouseSeatType",
            Image = Namespace + "Image",
            ImageSubject = Namespace + "ImageSubject",
            Incumbency = Namespace + "Incumbency",
            IncumbencyInterruption = Namespace + "IncumbencyInterruption",
            IndexingAndSearchThing = Namespace + "IndexingAndSearchThing",
            IndexingAndSearchWrittenQuestion = Namespace + "IndexingAndSearchWrittenQuestion",
            InForceTreaty = Namespace + "InForceTreaty",
            InformallyConstitutedCommittee = Namespace + "InformallyConstitutedCommittee",
            LaidThing = Namespace + "LaidThing",
            Laying = Namespace + "Laying",
            LayingBody = Namespace + "LayingBody",
            LayingPerson = Namespace + "LayingPerson",
            LocatedSignatureCount = Namespace + "LocatedSignatureCount",
            Logo = Namespace + "Logo",
            LogoImage = Namespace + "LogoImage",
            MadeStatutoryInstrumentPaper = Namespace + "MadeStatutoryInstrumentPaper",
            Member = Namespace + "Member",
            MemberImage = Namespace + "MemberImage",
            MiscellaneousSeriesMembership = Namespace + "MiscellaneousSeriesMembership",
            MnisAnsweringBody = Namespace + "MnisAnsweringBody",
            MnisConstituencyGroup = Namespace + "MnisConstituencyGroup",
            MnisContactPoint = Namespace + "MnisContactPoint",
            MnisDepartmentGroup = Namespace + "MnisDepartmentGroup",
            MnisElectionType = Namespace + "MnisElectionType",
            MnisFormalBodyChairIncumbency = Namespace + "MnisFormalBodyChairIncumbency",
            MnisGender = Namespace + "MnisGender",
            MnisGovernmentIncumbency = Namespace + "MnisGovernmentIncumbency",
            MnisGovernmentPosition = Namespace + "MnisGovernmentPosition",
            MnisHouseSeatType = Namespace + "MnisHouseSeatType",
            MnisFormalBody = Namespace + "MnisFormalBody",
            MnisFormalBodyLayPerson = Namespace + "MnisFormalBodyLayPerson",
            MnisFormalBodyMembership = Namespace + "MnisFormalBodyMembership",
            MnisMember = Namespace + "MnisMember",
            MnisOppositionIncumbency = Namespace + "MnisOppositionIncumbency",
            MnisOppositionPosition = Namespace + "MnisOppositionPosition",
            MnisParty = Namespace + "MnisParty",
            MnisPartyMembership = Namespace + "MnisPartyMembership",
            MnisSeatIncumbency = Namespace + "MnisSeatIncumbency",
            MnisThing = Namespace + "MnisThing",
            Moderation = Namespace + "Moderation",
            NamedThing = Namespace + "NamedThing",
            NonSelectCommittee = Namespace + "NonSelectCommittee",
            OnsConstituencyGroup = Namespace + "OnsConstituencyGroup",
            OnsThing = Namespace + "OnsThing",
            OppositionIncumbency = Namespace + "OppositionIncumbency",
            OppositionPerson = Namespace + "OppositionPerson",
            OppositionPosition = Namespace + "OppositionPosition",
            OralAnswer = Namespace + "OralAnswer",
            OralAnswerExpectation = Namespace + "OralAnswerExpectation",
            ParliamentaryCommittee = Namespace + "ParliamentaryCommittee",
            ParliamentaryQuestion = Namespace + "ParliamentaryQuestion",
            ParliamentaryIncumbency = Namespace + "ParliamentaryIncumbency",
            ParliamentPeriod = Namespace + "ParliamentPeriod",
            Party = Namespace + "Party",
            PartyMember = Namespace + "PartyMember",
            PartyMembership = Namespace + "PartyMembership",
            PastConstituencyGroup = Namespace + "PastConstituencyGroup",
            PastFormalBody = Namespace + "PastFormalBody",
            PastFormalBodyMembership = Namespace + "PastFormalBodyMembership",
            PastGroup = Namespace + "PastGroup",
            PastIncumbency = Namespace + "PastIncumbency",
            PastIncumbencyInterruption = Namespace + "PastIncumbencyInterruption",
            PastParliamentaryIncumbency = Namespace + "PastParliamentaryIncumbency",
            PastParliamentPeriod = Namespace + "PastParliamentPeriod",
            PastPartyMembership = Namespace + "PastPartyMembership",
            PastThing = Namespace + "PastThing",
            Person = Namespace + "Person",
            PersonImage = Namespace + "PersonImage",
            PersonWebLink = Namespace + "PersonWebLink",
            PimsPerson = Namespace + "PimsPerson",
            PimsThing = Namespace + "PimsThing",
            Place = Namespace + "Place",
            Position = Namespace + "Position",
            PostalAddress = Namespace + "PostalAddress",
            PrecludedProcedureRoute = Namespace + "PrecludedProcedureRoute",
            Procedure = Namespace + "Procedure",
            ProcedureStep = Namespace + "ProcedureStep",
            ProcedureStepPublication = Namespace + "ProcedureStepPublication",
            ProcedureRoute = Namespace + "ProcedureRoute",
            ProposedNegativeStatutoryInstrumentPaper = Namespace + "ProposedNegativeStatutoryInstrumentPaper",
            ProrogationAnswer = Namespace + "ProrogationAnswer",
            PursuedThing = Namespace + "PursuedThing",
            Question = Namespace + "Question",
            Rejection = Namespace + "Rejection",
            RejectionCode = Namespace + "RejectionCode",
            RejectedEPetition = Namespace + "RejectedEPetition",
            RequiredProcedureRoute = Namespace + "RequiredProcedureRoute",
            RoundRobin = Namespace + "RoundRobin",
            SeatIncumbency = Namespace + "SeatIncumbency",
            SelectCommittee = Namespace + "SelectCommittee",
            SeriesMembership = Namespace + "SeriesMembership",
            SesThing = Namespace + "SesThing",
            SinceCorrectedAnswer = Namespace + "SinceCorrectedAnswer",
            StatutoryCommittee = Namespace + "StatutoryCommittee",
            StatutoryInstrumentPaper = Namespace + "StatutoryInstrumentPaper",
            SubjectTaggedThing = Namespace + "SubjectTaggedThing",
            SubstantiveAnswer = Namespace + "SubstantiveAnswer",
            TemporalThing = Namespace + "TemporalThing",
            Territory = Namespace + "Territory",
            ThingWithLogo = Namespace + "ThingWithLogo",
            Threshold = Namespace + "Threshold"
,           ThresholdAttainment = Namespace + "ThresholdAttainment",
            Treaty = Namespace + "Treaty",
            TreatySeriesMembership = Namespace + "TreatySeriesMembership",
            UkgapEPetition = Namespace + "UkgapEPetition",
            UkgapThing = Namespace + "UkgapThing",
            WebLink = Namespace + "WebLink",
            WebLinkedThing = Namespace + "WebLinkedThing",
            WebsiteDescribedThing = Namespace + "WebsiteDescribedThing",
            WebsiteLabelledThing = Namespace + "WebsiteLabelledThing",
            WikidataResource = Namespace + "WikidataResource",
            WikidataThing = Namespace + "WikidataThing",
            Withdrawal = Namespace + "Withdrawal",
            WithdrawnThing = Namespace + "WithdrawnThing",
            WorkPackage = Namespace + "WorkPackage",
            WorkPackagedThing = Namespace + "WorkPackagedThing",
            WorkPackagedThingWebLink = Namespace + "WorkPackagedThingWebLink",
            WrittenAnswer = Namespace + "WrittenAnswer",
            WrittenAnswerExpectation = Namespace + "WrittenAnswerExpectation";

        /// <summary>
        /// Constant URIs for object properties in the UK Parliament Ontology
        /// </summary>
        /// TODO Everything after incumbencyInterruptionHasIncumbency
        public const string
            AnswerIsReplacedByAnswer = Namespace + "answerIsReplacedByAnswer",
            AnswerReplacesAnswer = Namespace + "answerReplacesAnswer",
            BusinessItemHasParliamentPeriod = Namespace + "businessItemHasParliamentPeriod",
            BusinessItemHasProcedureStep = Namespace + "businessItemHasProcedureStep",
            CorrectingAnswerReplacesSinceCorrectedAnswer = Namespace + "correctingAnswerReplacesSinceCorrectedAnswer",
            CountrySeriesMembershipHasTreaty = Namespace + "countrySeriesMembershipHasTreaty",
            EuropeanUnionSeriesMembershipHasTreaty = Namespace + "europeanUnionSeriesMembershipHasTreaty",
            GroupName = Namespace + "groupName",
            HoldingAnswerIsReplacedBySubstantiveAnswer = Namespace + "holdingAnswerIsReplacedBySubstantiveAnswer",
            HouseName = Namespace + "houseName",
            IncumbencyHasIncumbencyInterruption = Namespace + "incumbencyHasIncumbencyInterruption",
            IncumbencyInterruptionHasIncumbency = Namespace + "incumbencyInterruptionHasIncumbency",
            InForceTreatyHasTreatySeriesMembership = Namespace + "inForceTreatyHasTreatySeriesMembership",
            LayingDate = Namespace + "layingDate",
            LaidThingHasLaying = Namespace + "laidThingHasLaying",
            LaidThingName = Namespace + "laidThingName",
            LayingBodyHasLaying = Namespace + "layingBodyHasLaying",
            LayingHasLaidThing = Namespace + "layingHasLaidThing",
            LayingHasLayingBody = Namespace + "layingHasLayingBody",
            LayingHasLayingPerson = Namespace + "layingHasLayingPerson",
            LayingPersonHasLaying = Namespace + "layingPersonHasLaying",
            LeadGovernmentOrganisationHasTreaty = Namespace + "leadGovernmentOrganisationHasTreaty",
            MiscellaneousSeriesMembershipHasTreaty = Namespace + "miscellaneousSeriesMembershipHasTreaty",
            ParliamentPeriodHasBusinessItem = Namespace + "parliamentPeriodHasBusinessItem",
            PersonFamilyName = Namespace + "personFamilyName",
            ProcedureDescription = Namespace + "procedureDescription",
            ProcedureName = Namespace + "procedureName",
            ProcedureStepCommonlyActualisedAlongsideProcedureStep = Namespace + "procedureStepCommonlyActualisedAlongsideProcedureStep",
            ProcedureStepHasHouse = Namespace + "procedureStepHasHouse",
            ProcedureStepHasProcedureStepPublication = Namespace + "procedureStepHasProcedureStepPublication",
            ProcedureStepPublicationHasProcedureStep = Namespace + "procedureStepPublicationHasProcedureStep",
            SeriesMembershipHasTreaty = Namespace + "seriesMembershipHasTreaty",
            SinceCorrectedAnswerIsReplacedByCorrectingAnswer = Namespace + "sinceCorrectedAnswerIsReplacedByCorrectingAnswer",
            SubstantiveAnswerReplacesHoldingAnswer = Namespace + "substantiveAnswerReplacesHoldingAnswer",
            TreatyHasCountrySeriesMembership = Namespace + "treatyHasCountrySeriesMembership",
            TreatyHasEuropeanUnionSeriesMembership = Namespace + "treatyHasEuropeanUnionSeriesMembership",
            TreatyHasLeadGovernmentOrganisation = Namespace + "treatyHasLeadGovernmentOrganisation",
            TreatyHasMiscellaneousSeriesMembership = Namespace + "treatyHasMiscellaneousSeriesMembership",
            TreatyHasSeriesMembership = Namespace + "treatyHasSeriesMembership",
            TreatySeriesMembershipHasInForceTreaty = Namespace + "treatySeriesMembershipHasInForceTreaty",
            WithdrawalHasWithdrawnThing = Namespace + "withdrawalHasWithdrawnThing",
            WithdrawnThingHasWithdrawal = Namespace + "withdrawnThingHasWithdrawal",
            WorkPackagedThingHasWorkPackage = Namespace + "workPackagedThingHasWorkPackage",
            WorkPackageHasProcedure = Namespace + "workPackageHasProcedure";

        /// <summary>
        /// Constant URIs for datatype properties in the UK Parliament Ontology
        /// </summary>

        /// <summary>
        /// Constant URIs for annotation properties in the UK Parliament Ontology
        /// </summary>
        public const string
            WebsiteLabel = Namespace + "websiteLabel",
            WebsiteDescription = Namespace + "websiteDescription";

        /// <summary>
        /// Constant URIs for restrictions in the UK Parliament Ontology
        /// </summary>
        public const string
            GeneralCommitteeType = Namespace + "GeneralCommitteeType",
            InformallyConstitutedCommitteeType = Namespace + "InformallyConstitutedCommitteeType",
            NonSelectCommitteeType = Namespace + "NonSelectCommitteeType",
            SelectCommitteeType = Namespace + "SelectCommitteeType",
            StatutoryCommitteeType = Namespace + "StatutoryCommitteeType";
    }
}