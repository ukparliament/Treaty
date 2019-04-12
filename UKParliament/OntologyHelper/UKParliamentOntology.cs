namespace OntologyHelper
{
    using System;
    using System.Collections.Generic;
    using VDS.RDF;

    public static class UKParliamentOntology
    {
        internal static readonly NodeFactory nodeFactory = new NodeFactory();

        public static readonly Uri BaseUri = new Uri("https://id.parliament.uk/");

        public static readonly Uri Namespace = new Uri("https://id.parliament.uk/schema/");

        #region OWL classes definition
        public static class AllowedProcedureRoute
        {
            public static string Id => "AllowedProcedureRoute";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Allowed procedure route";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class AlternateMembership
        {
            public static string Id => "AlternateMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Alternate membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Answer
        {
            public static string Id => "Answer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class AnswerExpectation
        {
            public static string Id => "AnswerExpectation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Answer expectation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class AnsweringBody
        {
            public static string Id => "AnsweringBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Answering body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class AnsweringBodyAllocation
        {
            public static string Id => "AnsweringBodyAllocation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Answering body allocation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Approval
        {
            public static string Id => "Approval";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Approval";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ApprovedEPetition
        {
            public static string Id => "ApprovedEPetition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Approved e-petition";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ArmsLengthBody
        {
            public static string Id => "ArmsLengthBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Arm's length body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class BusinessItem
        {
            public static string Id => "BusinessItem";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Business item";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class BusinessItemWebLink
        {
            public static string Id => "BusinessItemWebLink";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Business item web link";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Candidacy
        {
            public static string Id => "Candidacy";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Candidacy";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class CandidacyResult
        {
            public static string Id => "CandidacyResult";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Candidacy result";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Candidate
        {
            public static string Id => "Candidate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Candidate";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class CausedProcedureRoute
        {
            public static string Id => "CausedProcedureRoute";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Caused procedure route";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Concept
        {
            public static string Id => "Concept";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Concept";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ConceptualisedThing
        {
            public static string Id => "ConceptualisedThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Conceptualised thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ConstituencyArea
        {
            public static string Id => "ConstituencyArea";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Constituency area";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ConstituencyGroup
        {
            public static string Id => "ConstituencyGroup";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Constituency group";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ContactableThing
        {
            public static string Id => "ContactableThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Contactable thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ContactPoint
        {
            public static string Id => "ContactPoint";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Contact point";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class CorrectingAnswer
        {
            public static string Id => "CorrectingAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Correcting answer";
            public static string Comment => "An answer that corrects another";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Country
        {
            public static string Id => "Country";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Country";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class CountrySeriesMembership
        {
            public static string Id => "CountrySeriesMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Country series membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Debate
        {
            public static string Id => "Debate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Debate";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class DeceasedPerson
        {
            public static string Id => "DeceasedPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Deceased person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class DelegatedAnswer
        {
            public static string Id => "DelegatedAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Delegated answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class DodsPerson
        {
            public static string Id => "DodsPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Dods person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class DodsThing
        {
            public static string Id => "DodsThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Dods thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Election
        {
            public static string Id => "Election";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Election";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ElectionType
        {
            public static string Id => "ElectionType";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Election type";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ElectoralIncumbency
        {
            public static string Id => "ElectoralIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Electoral incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Electorate
        {
            public static string Id => "Electorate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Electorate";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class EPetition
        {
            public static string Id => "EPetition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "E-petition";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class EuropeanUnionSeriesMembership
        {
            public static string Id => "EuropeanUnionSeriesMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "European Union series membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ExOfficioMembership
        {
            public static string Id => "ExOfficioMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Ex officio membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ExternalThing
        {
            public static string Id => "ExternalThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "External thing";
            public static string Comment => "A thing which lives in our database but which we link to an external database by the inclusion of foreign identifiers";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Focus
        {
            public static string Id => "Focus";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Focus";
            public static string Comment => "A thing which is focussed upon, for example the thing that a Formal Body scrutineses during a Focus Period";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class FocusPeriod
        {
            public static string Id => "FocusPeriod";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Focus period";
            public static string Comment => "The period during which a thing is focussed upon";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class FormalBody
        {
            public static string Id => "FormalBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Formal body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class FormalBodyChair
        {
            public static string Id => "FormalBodyChair";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Formal body chair";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class FormalBodyMembership
        {
            public static string Id => "FormalBodyMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Formal body membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class FormalBodyPosition
        {
            public static string Id => "FormalBodyPosition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Formal body position";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class FormalBodyType
        {
            public static string Id => "FormalBodyType";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Formal body type";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Gender
        {
            public static string Id => "Gender";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Gender";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class GenderIdentity
        {
            public static string Id => "GenderIdentity";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Gender identity";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class GeneralCommittee
        {
            public static string Id => "GeneralCommittee";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "General committee";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class GeographicalThing
        {
            public static string Id => "GeographicalThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Geographical thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class GovernmentIncumbency
        {
            public static string Id => "GovernmentIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Government incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class GovernmentOrganisation
        {
            public static string Id => "GovernmentOrganisation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Government organisation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class GovernmentPerson
        {
            public static string Id => "GovernmentPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Government person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class GovernmentPosition
        {
            public static string Id => "GovernmentPosition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Government position";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class GovernmentResponse
        {
            public static string Id => "GovernmentResponse";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Government response";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class GovRegisterCountry
        {
            public static string Id => "GovRegisterCountry";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "GOV.UK Registers country";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class GovRegisterGovernmentOrganisation
        {
            public static string Id => "GovRegisterGovernmentOrganisation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "GOV.UK Registers government organisation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class GovRegisterTerritory
        {
            public static string Id => "GovRegisterTerritory";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "GOV.UK Registers territory";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class GovRegisterThing
        {
            public static string Id => "GovRegisterThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "GOV.UK Registers thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Group
        {
            public static string Id => "Group";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Group";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class HoldingAnswer
        {
            public static string Id => "HoldingAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Holding answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class House
        {
            public static string Id => "House";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "House";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class HouseSeat
        {
            public static string Id => "HouseSeat";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "House seat";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class HouseSeatType
        {
            public static string Id => "HouseSeatType";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "House seat type";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Image
        {
            public static string Id => "Image";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Image";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ImageSubject
        {
            public static string Id => "ImageSubject";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Image subject";
            public static string Comment => "The person or thing an image is of, which is depicted in the Image";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Incumbency
        {
            public static string Id => "Incumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class IncumbencyInterruption
        {
            public static string Id => "IncumbencyInterruption";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Incumbency interruption";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class IndexingAndSearchThing
        {
            public static string Id => "IndexingAndSearchThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Indexing & Search thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class IndexingAndSearchWrittenQuestion
        {
            public static string Id => "IndexingAndSearchWrittenQuestion";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Indexing & Search written question";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class InForceTreaty
        {
            public static string Id => "InForceTreaty";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "In force treaty";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class InformallyConstitutedCommittee
        {
            public static string Id => "InformallyConstitutedCommittee";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Informally-constituted committee";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class LaidThing
        {
            public static string Id => "LaidThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Laid thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Laying
        {
            public static string Id => "Laying";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Laying";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class LayingBody
        {
            public static string Id => "LayingBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Laying body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class LayingPerson
        {
            public static string Id => "LayingPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Laying person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class LocatedSignatureCount
        {
            public static string Id => "LocatedSignatureCount";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Located signature count";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Logo
        {
            public static string Id => "Logo";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Logo";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class LogoImage
        {
            public static string Id => "LogoImage";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Logo image";
            public static string Comment => "An image of a Logo";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MadeStatutoryInstrumentPaper
        {
            public static string Id => "MadeStatutoryInstrumentPaper";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Made statutory instrument paper";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Member
        {
            public static string Id => "Member";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Member";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MemberImage
        {
            public static string Id => "MemberImage";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Member image";
            public static string Comment => "An image of a Member";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MiscellaneousSeriesMembership
        {
            public static string Id => "MiscellaneousSeriesMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Miscellaneous series membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisAnsweringBody
        {
            public static string Id => "MnisAnsweringBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS answering body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisConstituencyGroup
        {
            public static string Id => "MnisConstituencyGroup";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS constituency group";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisContactPoint
        {
            public static string Id => "MnisContactPoint";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS contact point";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisDepartmentGroup
        {
            public static string Id => "MnisDepartmentGroup";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS department group";
            public static string Comment => "This is any group that has an ID from the MNIS Departments table. Said table sadly doesn't only contain Departments, or even Government Organisations";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisElectionType
        {
            public static string Id => "MnisElectionType";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS election type";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisFormalBody
        {
            public static string Id => "MnisFormalBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS formal body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisFormalBodyChairIncumbency
        {
            public static string Id => "MnisFormalBodyChairIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS formal body chair incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisFormalBodyLayPerson
        {
            public static string Id => "MnisFormalBodyLayPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS formal body layperson";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisFormalBodyMembership
        {
            public static string Id => "MnisFormalBodyMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS formal body membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisGender
        {
            public static string Id => "MnisGender";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS gender";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisGovernmentIncumbency
        {
            public static string Id => "MnisGovernmentIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS government incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisGovernmentPosition
        {
            public static string Id => "MnisGovernmentPosition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS government position";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisHouseSeatType
        {
            public static string Id => "MnisHouseSeatType";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS house seat type";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisMember
        {
            public static string Id => "MnisMember";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS member";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisOppositionIncumbency
        {
            public static string Id => "MnisOppositionIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS opposition incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisOppositionPosition
        {
            public static string Id => "MnisOppositionPosition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS opposition position";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisParty
        {
            public static string Id => "MnisParty";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS party";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisPartyMembership
        {
            public static string Id => "MnisPartyMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS party membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisSeatIncumbency
        {
            public static string Id => "MnisSeatIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS seat incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class MnisThing
        {
            public static string Id => "MnisThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Moderation
        {
            public static string Id => "Moderation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Moderation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class NamedThing
        {
            public static string Id => "NamedThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Named thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class NonSelectCommittee
        {
            public static string Id => "NonSelectCommittee";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Non-select committee";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class OnsConstituencyGroup
        {
            public static string Id => "OnsConstituencyGroup";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "ONS constituency group";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class OnsThing
        {
            public static string Id => "OnsThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "ONS thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class OppositionIncumbency
        {
            public static string Id => "OppositionIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Opposition incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class OppositionPerson
        {
            public static string Id => "OppositionPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Opposition person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class OppositionPosition
        {
            public static string Id => "OppositionPosition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Opposition position";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class OralAnswer
        {
            public static string Id => "OralAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Oral answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class OralAnswerExpectation
        {
            public static string Id => "OralAnswerExpectation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Oral answer expectation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ParliamentaryCommittee
        {
            public static string Id => "ParliamentaryCommittee";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Parliamentary committee";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ParliamentaryIncumbency
        {
            public static string Id => "ParliamentaryIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Parliamentary incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ParliamentaryQuestion
        {
            public static string Id => "ParliamentaryQuestion";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Parliamentary question";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ParliamentPeriod
        {
            public static string Id => "ParliamentPeriod";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Parliament period";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Party
        {
            public static string Id => "Party";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Party";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PartyMember
        {
            public static string Id => "PartyMember";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Party member";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PartyMembership
        {
            public static string Id => "PartyMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Party membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PastConstituencyGroup
        {
            public static string Id => "PastConstituencyGroup";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Past constituency group";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PastFormalBody
        {
            public static string Id => "PastFormalBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Past formal body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PastFormalBodyMembership
        {
            public static string Id => "PastFormalBodyMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Past formal body membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PastGroup
        {
            public static string Id => "PastGroup";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Past group";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PastIncumbency
        {
            public static string Id => "PastIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Past incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PastIncumbencyInterruption
        {
            public static string Id => "PastIncumbencyInterruption";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Past incumbency interruption";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PastParliamentaryIncumbency
        {
            public static string Id => "PastParliamentaryIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Past parliamentary incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PastParliamentPeriod
        {
            public static string Id => "PastParliamentPeriod";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Past parliament period";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PastPartyMembership
        {
            public static string Id => "PastPartyMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Past party membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PastThing
        {
            public static string Id => "PastThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Past thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Person
        {
            public static string Id => "Person";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PersonImage
        {
            public static string Id => "PersonImage";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Person image";
            public static string Comment => "An image of a Person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PersonWebLink
        {
            public static string Id => "PersonWebLink";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Person web link";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PimsPerson
        {
            public static string Id => "PimsPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "PIMS person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PimsThing
        {
            public static string Id => "PimsThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "PIMS thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Place
        {
            public static string Id => "Place";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Place";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Position
        {
            public static string Id => "Position";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Position";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PostalAddress
        {
            public static string Id => "PostalAddress";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Postal address";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PrecludedProcedureRoute
        {
            public static string Id => "PrecludedProcedureRoute";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Precluded procedure route";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Procedure
        {
            public static string Id => "Procedure";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Procedure";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ProcedureRoute
        {
            public static string Id => "ProcedureRoute";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Procedure route";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ProcedureStep
        {
            public static string Id => "ProcedureStep";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Procedure step";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ProcedureStepPublication
        {
            public static string Id => "ProcedureStepPublication";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Procedure step publication";
            public static string Comment => "The publication which contains the regular source of information about a given procedure step";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ProposedNegativeStatutoryInstrumentPaper
        {
            public static string Id => "ProposedNegativeStatutoryInstrumentPaper";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Proposed negative statutory instrument paper";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ProrogationAnswer
        {
            public static string Id => "ProrogationAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Prorogation answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class PursuedThing
        {
            public static string Id => "PursuedThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Pursued thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Question
        {
            public static string Id => "Question";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Question";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class RejectedEPetition
        {
            public static string Id => "RejectedEPetition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Rejected e-petition";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Rejection
        {
            public static string Id => "Rejection";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Rejection";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class RejectionCode
        {
            public static string Id => "RejectionCode";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Rejection code";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class RequiredProcedureRoute
        {
            public static string Id => "RequiredProcedureRoute";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Required procedure route";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class RoundRobin
        {
            public static string Id => "RoundRobin";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Round robin";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class SeatIncumbency
        {
            public static string Id => "SeatIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Seat incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class SelectCommittee
        {
            public static string Id => "SelectCommittee";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Select committee";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class SeriesMembership
        {
            public static string Id => "SeriesMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Series membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class SesThing
        {
            public static string Id => "SesThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "SES thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class SinceCorrectedAnswer
        {
            public static string Id => "SinceCorrectedAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Since-corrected answer";
            public static string Comment => "An answer that corrects another";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class StatutoryCommittee
        {
            public static string Id => "StatutoryCommittee";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Statutory committee";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class StatutoryInstrumentPaper
        {
            public static string Id => "StatutoryInstrumentPaper";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Statutory instrument paper";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class SubjectTaggedThing
        {
            public static string Id => "SubjectTaggedThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Subject-tagged thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class SubstantiveAnswer
        {
            public static string Id => "SubstantiveAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Substantive answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class TemporalThing
        {
            public static string Id => "TemporalThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Temporal thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Territory
        {
            public static string Id => "Territory";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Territory";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ThingWithLogo
        {
            public static string Id => "ThingWithLogo";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Thing with logo";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Threshold
        {
            public static string Id => "Threshold";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Threshold";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class ThresholdAttainment
        {
            public static string Id => "ThresholdAttainment";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Threshold attainment";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Treaty
        {
            public static string Id => "Treaty";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Treaty";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class TreatySeriesMembership
        {
            public static string Id => "TreatySeriesMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Treaty series membership";
            public static string Comment => "The membership a Treaty has of the Treaty Series, the membership of which makes it an In Force treaty";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class UkgapEPetition
        {
            public static string Id => "UkgapEPetition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "UK Government and Parliament e-petition";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class UkgapThing
        {
            public static string Id => "UkgapThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "UK Government and Parliament thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class WebLink
        {
            public static string Id => "WebLink";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Web link";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class WebLinkedThing
        {
            public static string Id => "WebLinkedThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Web-linked thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class WebsiteDescribedThing
        {
            public static string Id => "WebsiteDescribedThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Website Described Thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class WebsiteLabelledThing
        {
            public static string Id => "WebsiteLabelledThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Website Labelled Thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class WikidataResource
        {
            public static string Id => "WikidataResource";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Wikidata resource";
            public static string Comment => "Something with a URI from Wikidata, equivalent to a :WikidataThing with an https://id.parliament.uk/ URI";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class WikidataThing
        {
            public static string Id => "WikidataThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Wikidata thing";
            public static string Comment => "A thing which lives in our database and has an id.parliament.uk URI which has a counterpoint on Wikidata.  Not necessarily something which is orchestrated from Wikidata, which the [Source]Thing class name tends to indicate in our schema. A more unwieldy name might be ':WikidataEquivalentHavingThing'. Hopefully this comment ameliorates the slight inconsistency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class Withdrawal
        {
            public static string Id => "Withdrawal";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Withdrawal";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class WithdrawnThing
        {
            public static string Id => "WithdrawnThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Withdrawn thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class WorkPackage
        {
            public static string Id => "WorkPackage";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Work package";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class WorkPackagedThing
        {
            public static string Id => "WorkPackagedThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Work packaged thing";
            public static string Comment => "Any thing which can be the focus of a Work Package - for example statutory instrument papers.";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class WorkPackagedThingWebLink
        {
            public static string Id => "WorkPackagedThingWebLink";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Work packaged thing web link";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class WrittenAnswer
        {
            public static string Id => "WrittenAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Written answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        public static class WrittenAnswerExpectation
        {
            public static string Id => "WrittenAnswerExpectation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Written answer expectation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Class")),
            };
        };

        #endregion

        #region OWL object properties definition
        public static class AllowedProcedureRouteIsAllowedByProcedureStep
        {
            public static string Id => "allowedProcedureRouteIsAllowedByProcedureStep";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "allowed procedure route is allowed by procedure step";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class AlternateMembershipHasMember
        {
            public static string Id => "alternateMembershipHasMember";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "alternate membership has member";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class AnswerExpectationHasQuestion
        {
            public static string Id => "answerExpectationHasQuestion";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answer expectation has question";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class AnswerHasAnsweringBody
        {
            public static string Id => "answerHasAnsweringBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answer has answering body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class AnswerHasAnsweringPerson
        {
            public static string Id => "answerHasAnsweringPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answer has answering person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class AnswerHasQuestion
        {
            public static string Id => "answerHasQuestion";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answer has question";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class AnsweringBodyAllocationHasAnsweringBody
        {
            public static string Id => "answeringBodyAllocationHasAnsweringBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answering body allocation has answering body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class AnsweringBodyAllocationHasQuestion
        {
            public static string Id => "answeringBodyAllocationHasQuestion";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answering body allocation has question";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class AnsweringBodyAllocationReplacedByAnsweringBodyAllocation
        {
            public static string Id => "answeringBodyAllocationReplacedByAnsweringBodyAllocation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answering body allocation replaced by answering body allocation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class AnsweringBodyAllocationReplacesAnsweringBodyAllocation
        {
            public static string Id => "answeringBodyAllocationReplacesAnsweringBodyAllocation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answering body allocation replaces answering body allocation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class AnsweringBodyHasAnswer
        {
            public static string Id => "answeringBodyHasAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answering body has answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class AnsweringBodyHasAnsweringBodyAllocation
        {
            public static string Id => "answeringBodyHasAnsweringBodyAllocation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answering body has answering body allocation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class AnsweringBodyHasOralAnswer
        {
            public static string Id => "answeringBodyHasOralAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answering body has oral answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class AnsweringBodyHasWrittenAnswer
        {
            public static string Id => "answeringBodyHasWrittenAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answering body has written answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class AnsweringPersonHasAnswer
        {
            public static string Id => "answeringPersonHasAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answering person has answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class AnswerIsReplacedByAnswer
        {
            public static string Id => "answerIsReplacedByAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answer is replaced by answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class AnswerReplacesAnswer
        {
            public static string Id => "answerReplacesAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answer replaces answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ApprovalHasApprovedEPetition
        {
            public static string Id => "approvalHasApprovedEPetition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "approval has approved e-petition";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ApprovedEPetitionHasApproval
        {
            public static string Id => "approvedEPetitionHasApproval";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "approved e-petition has approval";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class ArmsLengthBodyHasDelegatedAnswer
        {
            public static string Id => "armsLengthBodyHasDelegatedAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "arms length body has delegated answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class AskingPersonHasQuestion
        {
            public static string Id => "askingPersonHasQuestion";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "asking person has question";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class BusinessItemHasBusinessItemWebLink
        {
            public static string Id => "businessItemHasBusinessItemWebLink";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "business item has business item web link";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class BusinessItemHasParliamentPeriod
        {
            public static string Id => "businessItemHasParliamentPeriod";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "business item has parliamentary period";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class BusinessItemHasProcedureStep
        {
            public static string Id => "businessItemHasProcedureStep";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "business item has procedure step";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class BusinessItemHasWorkPackage
        {
            public static string Id => "businessItemHasWorkPackage";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "business item has work package";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class BusinessItemWebLinkHasBusinessItem
        {
            public static string Id => "businessItemWebLinkHasBusinessItem";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "business item web link has business item";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class CandidacyHasCandidacyResult
        {
            public static string Id => "candidacyHasCandidacyResult";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "candidacy has candidacy result";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class CandidacyHasCandidate
        {
            public static string Id => "candidacyHasCandidate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "candidacy has candidate";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class CandidacyHasElection
        {
            public static string Id => "candidacyHasElection";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "candidacy has election";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class CandidacyHasParty
        {
            public static string Id => "candidacyHasParty";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "candidacy has party";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class CandidacyResultHasCandidacy
        {
            public static string Id => "candidacyResultHasCandidacy";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "candidacy result has candidacy";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class CandidacyResultHasElectoralIncumbency
        {
            public static string Id => "candidacyResultHasElectoralIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "candidacy result has electoral incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class CandidateHasCandidacy
        {
            public static string Id => "candidateHasCandidacy";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "candidate has candidacy";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class CausedProcedureRouteIsCausedByProcedureStep
        {
            public static string Id => "causedProcedureRouteIsCausedByProcedureStep";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "caused procedure route is caused by procedure step";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ConceptHasBroaderConcept
        {
            public static string Id => "conceptHasBroaderConcept";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "concept has broader concept";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ConceptHasConceptualisedThing
        {
            public static string Id => "conceptHasConceptualisedThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "concept has conceptualised thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ConceptHasNarrowerConcept
        {
            public static string Id => "conceptHasNarrowerConcept";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "concept has narrower concept";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ConceptHasSubjectTaggedThing
        {
            public static string Id => "conceptHasSubjectTaggedThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "concept has subject tagged thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ConceptualisedThingHasConcept
        {
            public static string Id => "conceptualisedThingHasConcept";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "conceptualised thing has concept";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ConstituencyAreaHasConstituencyGroup
        {
            public static string Id => "constituencyAreaHasConstituencyGroup";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "constituency area has constituency group";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class ConstituencyAreaHasCountry
        {
            public static string Id => "constituencyAreaHasCountry";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "constituency area has country";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ConstituencyGroupHasConstituencyArea
        {
            public static string Id => "constituencyGroupHasConstituencyArea";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "constituency group has constituency area";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ConstituencyGroupHasElectorate
        {
            public static string Id => "constituencyGroupHasElectorate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "constituency group has electorate";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class ConstituencyGroupHasHouseSeat
        {
            public static string Id => "constituencyGroupHasHouseSeat";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "constituency group has house seat";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class ContactableThingHasContactPoint
        {
            public static string Id => "contactableThingHasContactPoint";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "contactable thing has contact point";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ContactPointHasContactableThing
        {
            public static string Id => "contactPointHasContactableThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "contact point has contactable thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ContactPointHasElectoralIncumbency
        {
            public static string Id => "contactPointHasElectoralIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "contact point has electoral incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ContactPointHasFormalBody
        {
            public static string Id => "contactPointHasFormalBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "contact point has formal body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ContactPointHasHouse
        {
            public static string Id => "contactPointHasHouse";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "contact point has house";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ContactPointHasParliamentaryIncumbency
        {
            public static string Id => "contactPointHasParliamentaryIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "contact point has parliamentary incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ContactPointHasPerson
        {
            public static string Id => "contactPointHasPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "contact point has person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ContactPointHasPostalAddress
        {
            public static string Id => "contactPointHasPostalAddress";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "contact point has postal address";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ContainedByPlace
        {
            public static string Id => "containedByPlace";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "contained by place";
            public static string Comment => "Relates a place to a place it is contained by e.g. town in constituency in county in country.@en";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ContainsPlace
        {
            public static string Id => "containsPlace";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "contains place";
            public static string Comment => "Relates a place to a place it contains by e.g. country contains constituency contains town.@en";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class CorrectingAnswerHasQuestion
        {
            public static string Id => "correctingAnswerHasQuestion";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "correcting answer has question";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class CorrectingAnswerReplacesSinceCorrectedAnswer
        {
            public static string Id => "correctingAnswerReplacesSinceCorrectedAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "correcting answer replaces since-corrected answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class CountryHasConstituencyArea
        {
            public static string Id => "countryHasConstituencyArea";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "country has constituency area";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class CountrySeriesMembershipHasTreaty
        {
            public static string Id => "countrySeriesMembershipHasTreaty";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Country series membership has treaty";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class DebateHasEPetition
        {
            public static string Id => "debateHasEPetition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "debate has e-petition";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class DelegatedAnswerHasArmsLengthBody
        {
            public static string Id => "delegatedAnswerHasArmsLengthBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "delegated answer has arms length body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ElectionHasCandidacy
        {
            public static string Id => "electionHasCandidacy";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "election has candidacy";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class ElectionHasElectionType
        {
            public static string Id => "electionHasElectionType";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "election has election type";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ElectionHasElectorate
        {
            public static string Id => "electionHasElectorate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "election has electorate";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ElectionTypeHasElection
        {
            public static string Id => "electionTypeHasElection";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "election type has election";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class ElectoralIncumbencyHasCandidacyResult
        {
            public static string Id => "electoralIncumbencyHasCandidacyResult";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "electoral incumbency has candidacy result";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ElectoralIncumbencyHasContactPoint
        {
            public static string Id => "electoralIncumbencyHasContactPoint";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "electoral incumbency has contact point";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ElectorateHasConstitutencyGroup
        {
            public static string Id => "electorateHasConstitutencyGroup";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "electorate has constitutency group";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ElectorateHasElection
        {
            public static string Id => "electorateHasElection";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "electorate has election";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class EPetitionHasDebate
        {
            public static string Id => "ePetitionHasDebate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "e-petition has debate";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class EPetitionHasGovernmentResponse
        {
            public static string Id => "ePetitionHasGovernmentResponse";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "e-petition has government response";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class EPetitionHasLocatedSignatureCount
        {
            public static string Id => "ePetitionHasLocatedSignatureCount";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "e-petition has located signature count";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class EPetitionHasModeration
        {
            public static string Id => "ePetitionHasModeration";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "e-petition has moderation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class EPetitionHasThresholdAttainment
        {
            public static string Id => "ePetitionHasThresholdAttainment";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "e-petition has threshold attainment";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class EuropeanUnionSeriesMembershipHasTreaty
        {
            public static string Id => "europeanUnionSeriesMembershipHasTreaty";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "European Union series membership has treaty";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ExOfficioMembershipHasMember
        {
            public static string Id => "exOfficioMembershipHasMember";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "ex officio membership has member";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FocusHasFocusPeriod
        {
            public static string Id => "focusHasFocusPeriod";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "focus has focus period";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class FocusPeriodHasFocus
        {
            public static string Id => "focusPeriodHasFocus";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "focus period has focus";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class FocusPeriodHasFormalBody
        {
            public static string Id => "focusPeriodHasFormalBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "focus period has formal body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class FormalBodyChairHasFormalBody
        {
            public static string Id => "formalBodyChairHasFormalBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body chair has formal body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class FormalBodyHasChildFormalBody
        {
            public static string Id => "formalBodyHasChildFormalBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body has child formal body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class FormalBodyHasContactPoint
        {
            public static string Id => "formalBodyHasContactPoint";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body has contact point";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class FormalBodyHasFocusPeriod
        {
            public static string Id => "formalBodyHasFocusPeriod";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body has focus period";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class FormalBodyHasFormalBodyChair
        {
            public static string Id => "formalBodyHasFormalBodyChair";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body has formal body chair";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FormalBodyHasFormalBodyMembership
        {
            public static string Id => "formalBodyHasFormalBodyMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body has formal body membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class FormalBodyHasFormalBodyType
        {
            public static string Id => "formalBodyHasFormalBodyType";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body has formal body type";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class FormalBodyHasHouse
        {
            public static string Id => "formalBodyHasHouse";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body has house";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class FormalBodyHasLeadHouse
        {
            public static string Id => "formalBodyHasLeadHouse";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body has lead house";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FormalBodyHasParentFormalBody
        {
            public static string Id => "formalBodyHasParentFormalBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body has parent formal body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class FormalBodyMembershipHasFormalBody
        {
            public static string Id => "formalBodyMembershipHasFormalBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body membership has formal body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FormalBodyMembershipHasPerson
        {
            public static string Id => "formalBodyMembershipHasPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body membership has person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FormalBodyTypeHasFormalBody
        {
            public static string Id => "formalBodyTypeHasFormalBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body type has formal body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class GenderHasGenderIdentity
        {
            public static string Id => "genderHasGenderIdentity";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "gender has gender identity";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class GenderIdentityHasGender
        {
            public static string Id => "genderIdentityHasGender";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "gender identity has gender";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class GenderIdentityHasPerson
        {
            public static string Id => "genderIdentityHasPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "gender identity has person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class GovernmentIncumbencyHasGovernmentPerson
        {
            public static string Id => "governmentIncumbencyHasGovernmentPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "government incumbency has government person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class GovernmentIncumbencyHasGovernmentPosition
        {
            public static string Id => "governmentIncumbencyHasGovernmentPosition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "government incumbency has government position";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class GovernmentPersonHasGovernmentIncumbency
        {
            public static string Id => "governmentPersonHasGovernmentIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "government person has government incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class GovernmentPositionHasGovernmentIncumbency
        {
            public static string Id => "governmentPositionHasGovernmentIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "government position has government incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class GovernmentResponseHasEPetition
        {
            public static string Id => "governmentResponseHasEPetition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "government response has e-petition";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class GroupHasPosition
        {
            public static string Id => "groupHasPosition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "group has position";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class HoldingAnswerHasQuestion
        {
            public static string Id => "holdingAnswerHasQuestion";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "holding answer has question";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class HoldingAnswerIsReplacedBySubstantiveAnswer
        {
            public static string Id => "holdingAnswerIsReplacedBySubstantiveAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "holding answer is replaced by substantive answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class HouseHasContactPoint
        {
            public static string Id => "houseHasContactPoint";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "house has contact point";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class HouseHasFormalBody
        {
            public static string Id => "houseHasFormalBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "house has formal body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class HouseHasHouseSeat
        {
            public static string Id => "houseHasHouseSeat";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "house has house seat";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class HouseHasProcedureStep
        {
            public static string Id => "houseHasProcedureStep";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "house has procedure step";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class HouseSeatHasConstituencyGroup
        {
            public static string Id => "houseSeatHasConstituencyGroup";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "house seat has constituency group";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class HouseSeatHasHouse
        {
            public static string Id => "houseSeatHasHouse";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "house seat has house";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class HouseSeatHasHouseSeatType
        {
            public static string Id => "houseSeatHasHouseSeatType";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "house seat has house seat type";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class HouseSeatHasSeatIncumbency
        {
            public static string Id => "houseSeatHasSeatIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "house seat has seat incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class HouseSeatTypeHasHouseSeat
        {
            public static string Id => "houseSeatTypeHasHouseSeat";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "house seat type has house seat";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class ImageHasImageSubject
        {
            public static string Id => "imageHasImageSubject";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "image has image subject";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ImageSubjectHasImage
        {
            public static string Id => "imageSubjectHasImage";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "image subject has image";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class IncumbencyHasIncumbencyInterruption
        {
            public static string Id => "incumbencyHasIncumbencyInterruption";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "incumbency has incumbency interruption";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class IncumbencyHasPerson
        {
            public static string Id => "incumbencyHasPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "incumbency has person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class IncumbencyHasPosition
        {
            public static string Id => "incumbencyHasPosition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "incumbency has position";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class IncumbencyInterruptionHasIncumbency
        {
            public static string Id => "incumbencyInterruptionHasIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "incumbency interruption has incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class InForceTreatyHasTreatySeriesMembership
        {
            public static string Id => "inForceTreatyHasTreatySeriesMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "in force treaty has Treaty series membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class LaidThingHasLaying
        {
            public static string Id => "laidThingHasLaying";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "laid thing has laying";
            public static string Comment => "Laid thing can have one laying.";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class LayingBodyHasLaying
        {
            public static string Id => "layingBodyHasLaying";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "laying body has laying";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class LayingHasLaidThing
        {
            public static string Id => "layingHasLaidThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "laying has laid thing";
            public static string Comment => "Laying can have multiple laid things.";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class LayingHasLayingBody
        {
            public static string Id => "layingHasLayingBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "laying has laying body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class LayingHasLayingPerson
        {
            public static string Id => "layingHasLayingPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "laying has laying person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class LayingPersonHasLaying
        {
            public static string Id => "layingPersonHasLaying";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "laying person has laying";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class LeadGovernmentOrganisationHasTreaty
        {
            public static string Id => "leadGovernmentOrganisationHasTreaty";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "lead Government organisation has treaty";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class LeadHouseHasFormalBody
        {
            public static string Id => "leadHouseHasFormalBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "lead house has formal body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class LocatedSignatureCountHasEPetition
        {
            public static string Id => "locatedSignatureCountHasEPetition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "located signature count has e-petition";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class LocatedSignatureCountHasPlace
        {
            public static string Id => "locatedSignatureCountHasPlace";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "located signature count has place";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class LogoHasLogoImage
        {
            public static string Id => "logoHasLogoImage";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "logo has logo image";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class LogoHasThingWithLogo
        {
            public static string Id => "logoHasThingWithLogo";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "logo has thing with logo";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class LogoImageHasLogo
        {
            public static string Id => "logoImageHasLogo";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "logo image has logo";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class MemberHasAlternateMembership
        {
            public static string Id => "memberHasAlternateMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "member has alternate membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class MemberHasExOfficioMembership
        {
            public static string Id => "memberHasExOfficioMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "member has ex officio membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class MemberHasMemberImage
        {
            public static string Id => "memberHasMemberImage";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "member has member image";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class MemberHasParliamentaryIncumbency
        {
            public static string Id => "memberHasParliamentaryIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "member has parliamentary incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class MemberImageHasMember
        {
            public static string Id => "memberImageHasMember";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "member image has member";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class MiscellaneousSeriesMembershipHasTreaty
        {
            public static string Id => "miscellaneousSeriesMembershipHasTreaty";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Miscellaneous series membership has treaty";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ModerationHasEPetition
        {
            public static string Id => "moderationHasEPetition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "moderation has e-petition";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class OppositionIncumbencyHasOppositionPerson
        {
            public static string Id => "oppositionIncumbencyHasOppositionPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "opposition incumbency has opposition person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class OppositionIncumbencyHasOppositionPosition
        {
            public static string Id => "oppositionIncumbencyHasOppositionPosition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "opposition incumbency has opposition position";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class OppositionPersonHasOppositionIncumbency
        {
            public static string Id => "oppositionPersonHasOppositionIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "opposition person has opposition incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class OppositionPositionHasOppositionIncumbency
        {
            public static string Id => "oppositionPositionHasOppositionIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "opposition position has opposition incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class OralAnswerExpectationHasQuestion
        {
            public static string Id => "oralAnswerExpectationHasQuestion";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "oral answer expectation has question";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class OralAnswerHasAnsweringBody
        {
            public static string Id => "oralAnswerHasAnsweringBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "oral answer has answering body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ParliamentaryIncumbencyHasContactPoint
        {
            public static string Id => "parliamentaryIncumbencyHasContactPoint";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "parliamentary incumbency has contact point";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ParliamentaryIncumbencyHasMember
        {
            public static string Id => "parliamentaryIncumbencyHasMember";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "parliamentary incumbency has member";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ParliamentPeriodHasBusinessItem
        {
            public static string Id => "parliamentPeriodHasBusinessItem";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "parliamentary period has business item";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class ParliamentPeriodHasImmediatelyFollowingParliamentPeriod
        {
            public static string Id => "parliamentPeriodHasImmediatelyFollowingParliamentPeriod";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "parliament period has immediately following parliament period";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ParliamentPeriodHasImmediatelyPreviousParliamentPeriod
        {
            public static string Id => "parliamentPeriodHasImmediatelyPreviousParliamentPeriod";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "parliament period has immediately previous parliament period";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class ParliamentPeriodHasSeatIncumbency
        {
            public static string Id => "parliamentPeriodHasSeatIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "parliament period has seat incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class PartyhasCandidacy
        {
            public static string Id => "partyhasCandidacy";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "party has candidacy";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class PartyHasPartyMembership
        {
            public static string Id => "partyHasPartyMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "party has party membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class PartyMemberHasPartyMembership
        {
            public static string Id => "partyMemberHasPartyMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "party member has party membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class PartyMembershipHasParty
        {
            public static string Id => "partyMembershipHasParty";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "party membership has party";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PartyMembershipHasPartyMember
        {
            public static string Id => "partyMembershipHasPartyMember";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "party membership has party member";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PersonHasContactPoint
        {
            public static string Id => "personHasContactPoint";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "person has contact point";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class PersonHasFormalBodyMembership
        {
            public static string Id => "personHasFormalBodyMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "person has formal body membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class PersonHasGenderIdentity
        {
            public static string Id => "personHasGenderIdentity";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "person has gender identity";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class PersonHasIncumbency
        {
            public static string Id => "personHasIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "person has incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class PersonHasPersonImage
        {
            public static string Id => "personHasPersonImage";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "person has person image";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class PersonHasPersonWebLink
        {
            public static string Id => "personHasPersonWebLink";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "person has person web link";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class PersonImageHasPerson
        {
            public static string Id => "personImageHasPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "person image has person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class PersonWebLinkHasPerson
        {
            public static string Id => "personWebLinkHasPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "person web link has person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class PlaceHasLocatedSignatureCount
        {
            public static string Id => "placeHasLocatedSignatureCount";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "place has located signature count";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class PositionHasGroup
        {
            public static string Id => "positionHasGroup";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "position has group";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class PositionHasIncumbency
        {
            public static string Id => "positionHasIncumbency";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "position has incumbency";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class PostalAddressHasContactPoint
        {
            public static string Id => "postalAddressHasContactPoint";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "postal address has contact point";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class PrecludedProcedureRouteIsPrecludedByProcedureStep
        {
            public static string Id => "precludedProcedureRouteIsPrecludedByProcedureStep";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "precluded procedure route is precluded by procedure step";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ProcedureHasProcedureRoute
        {
            public static string Id => "procedureHasProcedureRoute";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure has procedure route";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ProcedureHasWorkPackage
        {
            public static string Id => "procedureHasWorkPackage";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure has work package";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ProcedureRouteHasProcedure
        {
            public static string Id => "procedureRouteHasProcedure";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure route has procedure";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ProcedureRouteIsFromProcedureStep
        {
            public static string Id => "procedureRouteIsFromProcedureStep";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure route is from procedure step";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ProcedureRouteIsToProcedureStep
        {
            public static string Id => "procedureRouteIsToProcedureStep";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure route is to procedure step";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ProcedureStepAllowsAllowedProcedureRoute
        {
            public static string Id => "procedureStepAllowsAllowedProcedureRoute";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step allows allowed procedure route";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ProcedureStepCausesCausedProcedureRoute
        {
            public static string Id => "procedureStepCausesCausedProcedureRoute";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step causes caused procedure route";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ProcedureStepHasBusinessItem
        {
            public static string Id => "procedureStepHasBusinessItem";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step has business item";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ProcedureStepHasHouse
        {
            public static string Id => "procedureStepHasHouse";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step has house";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ProcedureStepHasProcedureStepPublication
        {
            public static string Id => "procedureStepHasProcedureStepPublication";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step has procedure step publication";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ProcedureStepIsCommonlyActualisedAlongsideProcedureStep
        {
            public static string Id => "procedureStepIsCommonlyActualisedAlongsideProcedureStep";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step is commonly actualised alongside procedure step";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#SymmetricProperty")),
            };
        };

        public static class ProcedureStepIsFromProcedureRoute
        {
            public static string Id => "procedureStepIsFromProcedureRoute";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step is from procedure route";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ProcedureStepIsToProcedureRoute
        {
            public static string Id => "procedureStepIsToProcedureRoute";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step is to procedure route";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ProcedureStepPrecludesPrecludedProcedureRoute
        {
            public static string Id => "procedureStepPrecludesPrecludedProcedureRoute";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step precludes precluded procedure route";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ProcedureStepPublicationHasProcedureStep
        {
            public static string Id => "procedureStepPublicationHasProcedureStep";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step publication has procedure step";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ProcedureStepRequiresRequiredProcedureRoute
        {
            public static string Id => "procedureStepRequiresRequiredProcedureRoute";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step requires required procedure route";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ProposedNegativeStatutoryInstrumentPaperPrecedesStatutoryInstrumentPaper
        {
            public static string Id => "proposedNegativeStatutoryInstrumentPaperPrecedesStatutoryInstrumentPaper";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "proposed negative statutory instrument paper precedes statutory instrument paper";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ProrogationAnswerHasQuestion
        {
            public static string Id => "prorogationAnswerHasQuestion";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "prorogation answer has question";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class PursuedThingHasQuestion
        {
            public static string Id => "pursuedThingHasQuestion";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "pursued thing has question";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class QuestionHasAnswer
        {
            public static string Id => "questionHasAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "question has answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class QuestionHasAnswerExpectation
        {
            public static string Id => "questionHasAnswerExpectation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "question has answer expectation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class QuestionHasAnsweringBodyAllocation
        {
            public static string Id => "questionHasAnsweringBodyAllocation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "question has answering body allocation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class QuestionHasAskingPerson
        {
            public static string Id => "questionHasAskingPerson";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "question has asking person";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class QuestionHasCorrectingAnswer
        {
            public static string Id => "questionHasCorrectingAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "question has correcting answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class QuestionHasHoldingAnswer
        {
            public static string Id => "questionHasHoldingAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "question has holding answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class QuestionHasOralAnswerExpectation
        {
            public static string Id => "questionHasOralAnswerExpectation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "question has oral answer expectation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class QuestionHasProrogationAnswer
        {
            public static string Id => "questionHasProrogationAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "question has prorogation answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class QuestionHasPursuedThing
        {
            public static string Id => "questionHasPursuedThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "question has pursued thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class QuestionHasRoundRobin
        {
            public static string Id => "questionHasRoundRobin";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "question has round robin";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class QuestionHasSubstantiveAnswer
        {
            public static string Id => "questionHasSubstantiveAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "question has substantive answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class QuestionHasWrittenAnswerExpectation
        {
            public static string Id => "questionHasWrittenAnswerExpectation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "question has written answer expectation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class RejectedEPetitionHasRejection
        {
            public static string Id => "rejectedEPetitionHasRejection";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "rejected e-petition has rejection";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class RejectionCodeHasRejection
        {
            public static string Id => "rejectionCodeHasRejection";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "rejection code has rejection";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class RejectionHasRejectedEPetition
        {
            public static string Id => "rejectionHasRejectedEPetition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "rejection has rejected e-petition";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class RejectionHasRejectionCode
        {
            public static string Id => "rejectionHasRejectionCode";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "rejection has rejection code";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class RequiredProcedureRouteIsRequiredByProcedureStep
        {
            public static string Id => "requiredProcedureRouteIsRequiredByProcedureStep";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "required procedure route is required by procedure step";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class RoundRobinHasQuestion
        {
            public static string Id => "roundRobinHasQuestion";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "round robin has question";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class SeatIncumbencyHasHouseSeat
        {
            public static string Id => "seatIncumbencyHasHouseSeat";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "seat incumbency has house seat";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class SeatIncumbencyHasParliamentPeriod
        {
            public static string Id => "seatIncumbencyHasParliamentPeriod";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "seat incumbency has parliament period";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class SeriesMembershipHasTreaty
        {
            public static string Id => "seriesMembershipHasTreaty";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "series membership has treaty";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class SinceCorrectedAnswerIsReplacedByCorrectingAnswer
        {
            public static string Id => "sinceCorrectedAnswerIsReplacedByCorrectingAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "since-corrected answer is replaced by correcting answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class StatutoryInstrumentPaperFollowsProposedNegativeStatutoryInstrumentPaper
        {
            public static string Id => "statutoryInstrumentPaperFollowsProposedNegativeStatutoryInstrumentPaper";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "statutory instrument paper follows proposed negative statutory instrument paper";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class SubjectTaggedThingHasConcept
        {
            public static string Id => "subjectTaggedThingHasConcept";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "subject tagged thing has concept";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class SubstantiveAnswerHasQuestion
        {
            public static string Id => "substantiveAnswerHasQuestion";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "substantive answer has question";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class SubstantiveAnswerReplacesHoldingAnswer
        {
            public static string Id => "substantiveAnswerReplacesHoldingAnswer";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "substantive answer replaces holding answer";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ThingWithLogoHasLogo
        {
            public static string Id => "thingWithLogoHasLogo";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "thing with logo has logo";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ThresholdAttainmentHasEPetition
        {
            public static string Id => "thresholdAttainmentHasEPetition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "threshold attainment has e-petition";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class ThresholdAttainmentHasThreshold
        {
            public static string Id => "thresholdAttainmentHasThreshold";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "threshold attainment has threshold";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ThresholdHasThresholdAttainment
        {
            public static string Id => "thresholdHasThresholdAttainment";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "threshold has threshold attainment";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class TreatyHasCountrySeriesMembership
        {
            public static string Id => "treatyHasCountrySeriesMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "treaty has Country series membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class TreatyHasEuropeanUnionSeriesMembership
        {
            public static string Id => "treatyHasEuropeanUnionSeriesMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "treaty has European Union series membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class TreatyHasLeadGovernmentOrganisation
        {
            public static string Id => "treatyHasLeadGovernmentOrganisation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "treaty has lead Government organisation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class TreatyHasMiscellaneousSeriesMembership
        {
            public static string Id => "treatyHasMiscellaneousSeriesMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "treaty has Miscellaneous series membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class TreatyHasSeriesMembership
        {
            public static string Id => "treatyHasSeriesMembership";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "treaty has series membership";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class TreatySeriesMembershipHasInForceTreaty
        {
            public static string Id => "treatySeriesMembershipHasInForceTreaty";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Treaty series membership has in force treaty";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class WebLinkedThingHasWebLink
        {
            public static string Id => "webLinkedThingHasWebLink";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "web linked thing has web link";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class WebLinkHasWebLinkedThing
        {
            public static string Id => "webLinkHasWebLinkedThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "web link has web linked thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class WikidataResourceHasEquivalentWikidataThing
        {
            public static string Id => "wikidataResourceHasEquivalentWikidataThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Wikidata resource has equivalent Wikidata thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class WikidataThingHasEquivalentWikidataResource
        {
            public static string Id => "wikidataThingHasEquivalentWikidataResource";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Wikidata thing has equivalent Wikidata resource";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class WithdrawalHasWithdrawnThing
        {
            public static string Id => "withdrawalHasWithdrawnThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "withdrawal has withdrawn thing";
            public static string Comment => "Withdrawal can have multiple withdrawn things. Usually a withdrawal only withdraws things laid within 1 laying.";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class WithdrawnThingHasWithdrawal
        {
            public static string Id => "withdrawnThingHasWithdrawal";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "withdrawn thing has withdrawal";
            public static string Comment => "Withdrawn thing can have one withdrawal.";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class WorkPackagedThingHasWorkPackage
        {
            public static string Id => "workPackagedThingHasWorkPackage";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "work packaged thing has work package";
            public static string Comment => "A work packaged thing can be the focus of one work package.";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class WorkPackagedThingHasWorkPackagedThingWebLink
        {
            public static string Id => "workPackagedThingHasWorkPackagedThingWebLink";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "work packaged thing has work packaged thing web link";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class WorkPackagedThingWebLinkHasWorkPackagedThing
        {
            public static string Id => "workPackagedThingWebLinkHasWorkPackagedThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "work packaged thing web link has work packaged thing";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class WorkPackageHasBusinessItem
        {
            public static string Id => "workPackageHasBusinessItem";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "work package has business item";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class WorkPackageHasProcedure
        {
            public static string Id => "workPackageHasProcedure";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "work package has procedure";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class WorkPackageHasWorkPackagedThing
        {
            public static string Id => "workPackageHasWorkPackagedThing";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "work package has work packaged thing";
            public static string Comment => "A work package has one focus.";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#InverseFunctionalProperty")),
            };
        };

        public static class WrittenAnswerExpectationHasQuestion
        {
            public static string Id => "writtenAnswerExpectationHasQuestion";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "written answer expectation has question";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        public static class WrittenAnswerHasAnsweringBody
        {
            public static string Id => "writtenAnswerHasAnsweringBody";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "written answer has answering body";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#ObjectProperty")),
            };
        };

        #endregion

        #region OWL datatype properties definition
        public static class Action
        {
            public static string Id => "action";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "action";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class AdditionalDetails
        {
            public static string Id => "additionalDetails";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "additional details";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class AddressLine1
        {
            public static string Id => "addressLine1";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "address line 1";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class AddressLine2
        {
            public static string Id => "addressLine2";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "address line 2";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class AddressLine3
        {
            public static string Id => "addressLine3";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "address line 3";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class AddressLine4
        {
            public static string Id => "addressLine4";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "address line 4";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class AddressLine5
        {
            public static string Id => "addressLine5";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "address line 5";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class AnswerExpectationEndDate
        {
            public static string Id => "answerExpectationEndDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answer expectation end date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class AnswerExpectationStartDate
        {
            public static string Id => "answerExpectationStartDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answer expectation start date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class AnswerGivenDate
        {
            public static string Id => "answerGivenDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answer given date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class AnsweringBodyMnisId
        {
            public static string Id => "answeringBodyMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answering body MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class AnswerText
        {
            public static string Id => "answerText";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "answer text";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class ApprovedAt
        {
            public static string Id => "approvedAt";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "approved at";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class Background
        {
            public static string Id => "background";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "background";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class BusinessItemDate
        {
            public static string Id => "businessItemDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "business item date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class ClosedAt
        {
            public static string Id => "closedAt";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "closed at";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class CommonsSeatIncumbencyMnisId
        {
            public static string Id => "commonsSeatIncumbencyMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "commons seat incumbency MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ConceptDefinition
        {
            public static string Id => "conceptDefinition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "concept definition";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class ConceptLabel
        {
            public static string Id => "conceptLabel";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "concept label";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ConceptScopeNote
        {
            public static string Id => "conceptScopeNote";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "concept scope note";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class ConstituencyAreaExtent
        {
            public static string Id => "constituencyAreaExtent";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "constituency area extent";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class ConstituencyAreaLatitude
        {
            public static string Id => "constituencyAreaLatitude";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "constituency area latitude";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ConstituencyAreaLongitude
        {
            public static string Id => "constituencyAreaLongitude";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "constituency area longitude";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ConstituencyGroupEndDate
        {
            public static string Id => "constituencyGroupEndDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "constituency group end date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ConstituencyGroupMnisId
        {
            public static string Id => "constituencyGroupMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "constituency group MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ConstituencyGroupName
        {
            public static string Id => "constituencyGroupName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "constituency group name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ConstituencyGroupOnsCode
        {
            public static string Id => "constituencyGroupOnsCode";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "constituency group ONS code";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ConstituencyGroupStartDate
        {
            public static string Id => "constituencyGroupStartDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "constituency group start date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ContactForm
        {
            public static string Id => "contactForm";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "contact form";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ContactPointMnisId
        {
            public static string Id => "contactPointMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "contact point MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class CountryCitizenNames
        {
            public static string Id => "countryCitizenNames";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "country citizen names";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class CountryGovRegisterId
        {
            public static string Id => "countryGovRegisterId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "country GOV.UK Registers Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class CountryName
        {
            public static string Id => "countryName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "country name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class CountryOfficialName
        {
            public static string Id => "countryOfficialName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "country official name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class CountrySeriesItemCitation
        {
            public static string Id => "countrySeriesItemCitation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "country series item citation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class CreatedAt
        {
            public static string Id => "createdAt";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "created at";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class Date
        {
            public static string Id => "date";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class DebateDate
        {
            public static string Id => "debateDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "debate date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class DebateOverview
        {
            public static string Id => "debateOverview";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "debate overview";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class DebateProposedDate
        {
            public static string Id => "debateProposedDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "debate proposed date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class DebateTranscriptUrl
        {
            public static string Id => "debateTranscriptUrl";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "debate transcript url";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class DebateVideoUrl
        {
            public static string Id => "debateVideoUrl";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "debate video url";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class DodsId
        {
            public static string Id => "dodsId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Dods Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ElectionName
        {
            public static string Id => "electionName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "election name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ElectionTypeMnisId
        {
            public static string Id => "electionTypeMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "election type MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ElectionTypeName
        {
            public static string Id => "electionTypeName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "election type name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class Email
        {
            public static string Id => "email";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "email";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class EndDate
        {
            public static string Id => "endDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "end date";
            public static string Comment => "By convention, endDate is only used after the date.";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class EPetitionUkgapId
        {
            public static string Id => "ePetitionUkgapId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "e-petition UK Government and Parliament Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class EuropeanUnionSeriesItemCitation
        {
            public static string Id => "europeanUnionSeriesItemCitation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "European Union series item citation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ExternalIdentifier
        {
            public static string Id => "externalIdentifier";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "external identifier";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class FaxNumber
        {
            public static string Id => "faxNumber";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "fax number";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FocusPeriodEndDate
        {
            public static string Id => "focusPeriodEndDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "focus period end date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FocusPeriodStartDate
        {
            public static string Id => "focusPeriodStartDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "focus period start date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FormalBodyChairIncumbencyMnisId
        {
            public static string Id => "formalBodyChairIncumbencyMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body chair incumbency MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FormalBodyEndDate
        {
            public static string Id => "formalBodyEndDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body end date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FormalBodyLayPersonMnisId
        {
            public static string Id => "formalBodyLayPersonMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body lay person MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FormalBodyMembershipEndDate
        {
            public static string Id => "formalBodyMembershipEndDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body membership end date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FormalBodyMembershipMnisId
        {
            public static string Id => "formalBodyMembershipMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body membership MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FormalBodyMembershipStartDate
        {
            public static string Id => "formalBodyMembershipStartDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body membership start date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FormalBodyMnisId
        {
            public static string Id => "formalBodyMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FormalBodyName
        {
            public static string Id => "formalBodyName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FormalBodyRemit
        {
            public static string Id => "formalBodyRemit";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body remit";
            public static string Comment => "An atemporal description of the Formal Body's remit";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FormalBodyStartDate
        {
            public static string Id => "formalBodyStartDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body start date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class FormalBodyTypeName
        {
            public static string Id => "formalBodyTypeName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "formal body type name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class GenderMnisId
        {
            public static string Id => "genderMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "gender MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class GenderName
        {
            public static string Id => "genderName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "gender name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class GovernmentIncumbencyMnisId
        {
            public static string Id => "governmentIncumbencyMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "government incumbency MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class GovernmentOrganisationGovRegisterId
        {
            public static string Id => "governmentOrganisationGovRegisterId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "government organisation GOV.UK Registers Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class GovernmentPositionMnisId
        {
            public static string Id => "governmentPositionMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "government position MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class GovernmentResponseCreatedAt
        {
            public static string Id => "governmentResponseCreatedAt";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "government response created at";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class GovernmentResponseDetails
        {
            public static string Id => "governmentResponseDetails";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "government response details";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class GovernmentResponseSummary
        {
            public static string Id => "governmentResponseSummary";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "government response summary";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class GovernmentResponseUpdatedAt
        {
            public static string Id => "governmentResponseUpdatedAt";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "government response updated at";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class GovRegisterCountryEndDate
        {
            public static string Id => "govRegisterCountryEndDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "GOV.UK Registers country end date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class GovRegisterCountryStartDate
        {
            public static string Id => "govRegisterCountryStartDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "GOV.UK Registers country start date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class GovRegisterId
        {
            public static string Id => "govRegisterId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "GOV.UK Registers Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class GovRegisterTerritoryEndDate
        {
            public static string Id => "govRegisterTerritoryEndDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "GOV.UK Registers territory end date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class GovRegisterTerritoryStartDate
        {
            public static string Id => "govRegisterTerritoryStartDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "GOV.UK Registers territory start date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class GroupEndDate
        {
            public static string Id => "groupEndDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "group end date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class GroupName
        {
            public static string Id => "groupName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "group name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class GroupStartDate
        {
            public static string Id => "groupStartDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "group start date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class HouseName
        {
            public static string Id => "houseName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "house name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class HouseSeatName
        {
            public static string Id => "houseSeatName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "house seat name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class HouseSeatTypeDescription
        {
            public static string Id => "houseSeatTypeDescription";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "house seat type description";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class HouseSeatTypeMnisId
        {
            public static string Id => "houseSeatTypeMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "house seat type MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class HouseSeatTypeName
        {
            public static string Id => "houseSeatTypeName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "house seat type name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class IncumbencyEndDate
        {
            public static string Id => "incumbencyEndDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "incumbency end date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class IncumbencyInterruptionEndDate
        {
            public static string Id => "incumbencyInterruptionEndDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "incumbency interruption end date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class IncumbencyInterruptionStartDate
        {
            public static string Id => "incumbencyInterruptionStartDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "incumbency interruption start date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class IncumbencyStartDate
        {
            public static string Id => "incumbencyStartDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "incumbency start date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class IndexingAndSearchUri
        {
            public static string Id => "indexingAndSearchUri";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Indexing & Search URI";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class LaidThingName
        {
            public static string Id => "laidThingName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "laid thing name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class Latitude
        {
            public static string Id => "latitude";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "latitude";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class LayingDate
        {
            public static string Id => "layingDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "laying date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class Longitude
        {
            public static string Id => "longitude";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "longitude";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class LordsSeatIncumbencyMnisId
        {
            public static string Id => "lordsSeatIncumbencyMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "lords seat incumbency MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class MemberMnisId
        {
            public static string Id => "memberMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "member MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class MiscellaneousSeriesItemCitation
        {
            public static string Id => "miscellaneousSeriesItemCitation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "miscellaneous series item citation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class MnisDepartmentId
        {
            public static string Id => "mnisDepartmentId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS department Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class MnisId
        {
            public static string Id => "mnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class ModeratedAt
        {
            public static string Id => "moderatedAt";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "moderated at";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class Name
        {
            public static string Id => "name";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class OnsCode
        {
            public static string Id => "onsCode";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "ONS code";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class OppositionIncumbencyMnisId
        {
            public static string Id => "oppositionIncumbencyMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "opposition incumbency MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class OppositionPositionMnisId
        {
            public static string Id => "oppositionPositionMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "opposition position MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class OralAnswerExpectationSurrenderedAt
        {
            public static string Id => "oralAnswerExpectationSurrenderedAt";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "oral answer expectation surrendered at";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class OralAnswerExpectationTimedOutAt
        {
            public static string Id => "oralAnswerExpectationTimedOutAt";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "oral answer expectation timed out at";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class ParliamentaryIncumbencyEndDate
        {
            public static string Id => "parliamentaryIncumbencyEndDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "parliamentary incumbency end date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ParliamentaryIncumbencyStartDate
        {
            public static string Id => "parliamentaryIncumbencyStartDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "parliamentary incumbency start date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ParliamentaryQuestionWithdrawnOn
        {
            public static string Id => "parliamentaryQuestionWithdrawnOn";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "parliamentary question withdrawn on";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class ParliamentPeriodEndDate
        {
            public static string Id => "parliamentPeriodEndDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "parliament period end date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ParliamentPeriodNumber
        {
            public static string Id => "parliamentPeriodNumber";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "parliament period number";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ParliamentPeriodStartDate
        {
            public static string Id => "parliamentPeriodStartDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "parliament period start date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PartyMembershipEndDate
        {
            public static string Id => "partyMembershipEndDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "party membership end date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PartyMembershipMnisId
        {
            public static string Id => "partyMembershipMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "party membership MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PartyMembershipStartDate
        {
            public static string Id => "partyMembershipStartDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "party membership start date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PartyMnisId
        {
            public static string Id => "partyMnisId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "party MNIS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PartyName
        {
            public static string Id => "partyName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "party name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PersonDateOfBirth
        {
            public static string Id => "personDateOfBirth";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "person date of birth";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PersonDateOfDeath
        {
            public static string Id => "personDateOfDeath";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "person date of death";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PersonDodsId
        {
            public static string Id => "personDodsId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "person Dods Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PersonFamilyName
        {
            public static string Id => "personFamilyName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "person family name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PersonGivenName
        {
            public static string Id => "personGivenName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "person given name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PersonImageFaceCentrePoint
        {
            public static string Id => "personImageFaceCentrePoint";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "person image face centre point";
            public static string Comment => "The coordinates within an image marking the centrepoint of the face, for use in cropping";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class PersonOtherNames
        {
            public static string Id => "personOtherNames";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "person other names";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PersonPimsId
        {
            public static string Id => "personPimsId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "person PIMS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PhoneNumber
        {
            public static string Id => "phoneNumber";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "phone number";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PimsId
        {
            public static string Id => "pimsId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "PIMS Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PositionName
        {
            public static string Id => "positionName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "position name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class PostCode
        {
            public static string Id => "postCode";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "postcode";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ProcedureDescription
        {
            public static string Id => "procedureDescription";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure description";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ProcedureName
        {
            public static string Id => "procedureName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ProcedureStepDateNote
        {
            public static string Id => "procedureStepDateNote";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step date note";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ProcedureStepDescription
        {
            public static string Id => "procedureStepDescription";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step description";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ProcedureStepLinkNote
        {
            public static string Id => "procedureStepLinkNote";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step link note";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ProcedureStepName
        {
            public static string Id => "procedureStepName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ProcedureStepPublicationName
        {
            public static string Id => "procedureStepPublicationName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step publication name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class ProcedureStepPublicationUrl
        {
            public static string Id => "procedureStepPublicationUrl";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step publication name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class ProcedureStepScopeNote
        {
            public static string Id => "procedureStepScopeNote";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "procedure step scope note";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ProposedEndDate
        {
            public static string Id => "proposedEndDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "proposed end date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class ProposedNegativeStatutoryInstrumentPaperName
        {
            public static string Id => "proposedNegativeStatutoryInstrumentPaperName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "proposed negative statutory instrument paper name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ProposedStartDate
        {
            public static string Id => "proposedStartDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "proposed start date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class QuestionAskedAt
        {
            public static string Id => "questionAskedAt";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "question asked at";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class QuestionHeading
        {
            public static string Id => "questionHeading";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "question heading";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class QuestionText
        {
            public static string Id => "questionText";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "question text";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class RejectedAt
        {
            public static string Id => "rejectedAt";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "rejected at";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class RejectionCodeName
        {
            public static string Id => "rejectionCodeName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "rejection code name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class RejectionDetails
        {
            public static string Id => "rejectionDetails";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "rejection details";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class ResultPosition
        {
            public static string Id => "resultPosition";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "result position";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class SeriesItemCitation
        {
            public static string Id => "seriesItemCitation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "series item citation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class SesId
        {
            public static string Id => "sesId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "SES Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class SignatureCount
        {
            public static string Id => "signatureCount";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "signature count";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class SignatureCountRetrievedAt
        {
            public static string Id => "signatureCountRetrievedAt";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "signature count retrieved at";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class StartDate
        {
            public static string Id => "startDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "start date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class StatutoryInstrumentPaperComingIntoForceDate
        {
            public static string Id => "statutoryInstrumentPaperComingIntoForceDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "statutory instrument paper coming into force date";
            public static string Comment => "The date on which the statutory instrument came, or is going to come, into force. Where given, this will be the date on which the whole statutory instrument comes into force. Sometimes coming into force will be fuzzier than a given date e.g. different schedules within the SI will come into force at different times. In these cases there'll be no comingIntoForceDate; the coming into force details will be given as a comingIntoForceNote. Coming into force note precludes coming into force date.";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class StatutoryInstrumentPaperComingIntoForceNote
        {
            public static string Id => "statutoryInstrumentPaperComingIntoForceNote";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "statutory instrument paper coming into force note";
            public static string Comment => "A note to say when the statutory instrument came, or is going to come, into force. Sometimes coming into force will be fuzzier than a given date e.g. different schedules within the SI will come into force at different times. In these cases there'll be no comingIntoForceDate but the coming into force details will be given as a comingIntoForceNote. Coming into force date precludes coming into force note.";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class StatutoryInstrumentPaperMadeDate
        {
            public static string Id => "statutoryInstrumentPaperMadeDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "statutory instrument paper made date";
            public static string Comment => "The date on which the statutory instrument was made. Note that the process of making happens outside Parliament, by the minister responsible for the statutory instrument.";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class StatutoryInstrumentPaperName
        {
            public static string Id => "statutoryInstrumentPaperName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "statutory instrument paper name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class StatutoryInstrumentPaperNumber
        {
            public static string Id => "statutoryInstrumentPaperNumber";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "statutory instrument number";
            public static string Comment => "Statutory instrument papers are given a number in the SI series which runs from number 1 each calendar year. SIs may be cited using prefix number and year e.g. SI 1986/935";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class StatutoryInstrumentPaperPrefix
        {
            public static string Id => "statutoryInstrumentPaperPrefix";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "statutory instrument paper prefix";
            public static string Comment => "Usually this will be SI. Other prefixes, such as for regulations include SR (NI).";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class StatutoryInstrumentPaperYear
        {
            public static string Id => "statutoryInstrumentPaperYear";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "statutory instrument paper year";
            public static string Comment => "The year of a statutory instrument paper. Usually this will be the year it was laid before Parliament. Occasionally a statutory instrument laid in one calendar year and made the following calendar year will have its SI year updated.";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class TerritoryGovRegisterId
        {
            public static string Id => "territoryGovRegisterId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "territory GOV.UK Registers Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class TerritoryName
        {
            public static string Id => "territoryName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "territory name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class TerritoryOfficialName
        {
            public static string Id => "territoryOfficialName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "territory official name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class ThresholdAttainmentAt
        {
            public static string Id => "thresholdAttainmentAt";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "threshold attainment at";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class ThresholdName
        {
            public static string Id => "thresholdName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "threshold name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class ThresholdSignatureNumber
        {
            public static string Id => "thresholdSignatureNumber";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "threshold signature number";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class TreatyComingIntoForceDate
        {
            public static string Id => "treatyComingIntoForceDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "treaty coming into force date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class TreatyComingIntoForceNote
        {
            public static string Id => "treatyComingIntoForceNote";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "treaty coming into force note";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class TreatyCommandPaperNumber
        {
            public static string Id => "treatyCommandPaperNumber";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "command paper number";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class TreatyCommandPaperPrefix
        {
            public static string Id => "treatyCommandPaperPrefix";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "command paper prefix";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class TreatyName
        {
            public static string Id => "treatyName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "treaty name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class TreatySeriesItemCitation
        {
            public static string Id => "treatySeriesItemCitation";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "treaty series item citation";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class UkgapId
        {
            public static string Id => "ukgapId";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "UK Government and Parliament Id";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class UpdatedAt
        {
            public static string Id => "updatedAt";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "updated at";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        public static class VoteCount
        {
            public static string Id => "voteCount";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "vote count";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class WithdrawalDate
        {
            public static string Id => "withdrawalDate";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "withdrawal date";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class WorkPackagedThingName
        {
            public static string Id => "workPackagedThingName";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "work packaged thing name";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#FunctionalProperty")),
            };
        };

        public static class WrittenQuestionIndexingAndSearchUin
        {
            public static string Id => "writtenQuestionIndexingAndSearchUin";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "written question Indexing & Search UIN";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#DatatypeProperty")),
            };
        };

        #endregion

        #region OWL annotation properties definition
        public static class WebsiteDescription
        {
            public static string Id => "websiteDescription";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Website description";
            public static string Comment => "Allows the website to display a more user-friendly equivalent to rdfs:comment";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#AnnotationProperty")),
            };
        };

        public static class WebsiteLabel
        {
            public static string Id => "websiteLabel";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Website label";
            public static string Comment => "Allows the website to display a more user-friendly equivalent to rdfs:label";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#AnnotationProperty")),
            };
        };

        #endregion

        #region OWL restrictions definition
        public static class GeneralCommitteeType
        {
            public static string Id => "GeneralCommitteeType";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "General committee type";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Restriction")),
            };
        };

        public static class InformallyConstitutedCommitteeType
        {
            public static string Id => "InformallyConstitutedCommitteeType";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Informally-constituted committee type";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Restriction")),
            };
        };

        public static class NonSelectCommitteeType
        {
            public static string Id => "NonSelectCommitteeType";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Non-select committee type";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Restriction")),
            };
        };

        public static class SelectCommitteeType
        {
            public static string Id => "SelectCommitteeType";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Select committee type";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Restriction")),
            };
        };

        public static class StatutoryCommitteeType
        {
            public static string Id => "StatutoryCommitteeType";
            public static Uri Uri => new Uri(Namespace, Id);
            public static string Label => "Statutory committee type";
            public static ICollection<INode> Type => new List<INode> {
                nodeFactory.CreateUriNode(UriFactory.Create("http://www.w3.org/2002/07/owl#Restriction")),
            };
        };

        #endregion
    }
}
