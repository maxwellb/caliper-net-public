﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImsGlobal.Caliper.Tests {
	using ImsGlobal.Caliper.Entities;
	using ImsGlobal.Caliper.Entities.Assessment;
	using ImsGlobal.Caliper.Entities.Assignable;
	using ImsGlobal.Caliper.Entities.Lis;
	using ImsGlobal.Caliper.Entities.Media;
	using ImsGlobal.Caliper.Entities.Outcome;
	using ImsGlobal.Caliper.Entities.Reading;

	internal static class TestEntities {

		public static SoftwareApplication Readium = new SoftwareApplication( "https://github.com/readium/readium-js-viewer" ) {
			Name = "Readium",
			LastModifiedAt = 1402965614516L
		};

		public static Person Student554433 = new Person( "https://some-university.edu/user/554433" ) {
			LastModifiedAt = 1402965614516L
		};

		public static CourseSection AmRev101 = new CourseSection( "https://some-university.edu/politicalScience/2014/american-revolution-101" ) {
			Semester = "Spring-2014",
			CourseNumber = "AmRev-101",
			Label = "Am Rev 101",
			Name = "American Revolution 101",
			LastModifiedAt = 1402965614516L
		};

		public static WebPage AmRev101LandingPage = new WebPage( "AmRev-101-landingPage" ) {
			Name = "American Revolution 101 Landing Page",
			PartOf = AmRev101,
			LastModifiedAt = 1402965614516L
		};

		public static EPubVolume EpubVolume43 = new EPubVolume( "https://github.com/readium/readium-js-viewer/book/34843#epubcfi(/4/3)" ) {
			Name = "The Glorious Cause: The American Revolution, 1763-1789 (Oxford History of the United States)",
			LastModifiedAt = 1402965614516L
		};

		public static EPubSubChapter EpubSubChap431 = new EPubSubChapter( "https://github.com/readium/readium-js-viewer/book/34843#epubcfi(/4/3/1)" ) {
			Name = "Key Figures: George Washington",
			PartOf = EpubVolume43,
			LastModifiedAt = 1402965614516L
		};

		public static Frame EpubSubChap431_Frame = new Frame( EpubSubChap431.Id ) {
			Name = EpubSubChap431.Name,
			PartOf = EpubVolume43,
			Index = 1,
			LastModifiedAt = 1402965614516L
		};

		public static EPubSubChapter EpubSubChap432 = new EPubSubChapter( "https://github.com/readium/readium-js-viewer/book/34843#epubcfi(/4/3/2)" ) {
			Name = "Key Figures: Lord North",
			PartOf = EpubVolume43,
			LastModifiedAt = 1402965614516L
		};

		public static Frame EpubSubChap432_Frame = new Frame( EpubSubChap432.Id ) {
			Name = EpubSubChap432.Name,
			PartOf = EpubVolume43,
			Index = 2,
			LastModifiedAt = 1402965614516L
		};

		public static EPubSubChapter EpubSubChap433 = new EPubSubChapter( "https://github.com/readium/readium-js-viewer/book/34843#epubcfi(/4/3/3)" ) {
			Name = "Key Figures: John Adams",
			PartOf = EpubVolume43,
			LastModifiedAt = 1402965614516L
		};

		public static Frame EpubSubChap433_Frame = new Frame( EpubSubChap433.Id ) {
			Name = EpubSubChap433.Name,
			PartOf = EpubVolume43,
			Index = 3,
			LastModifiedAt = 1402965614516L
		};

		public static EPubSubChapter EpubSubChap434 = new EPubSubChapter( "https://github.com/readium/readium-js-viewer/book/34843#epubcfi(/4/3/4)" ) {
			Name = "The Stamp Act Crisis",
			PartOf = EpubVolume43,
			LastModifiedAt = 1402965614516L
		};

		public static Frame EpubSubChap434_Frame = new Frame( EpubSubChap434.Id ) {
			Name = EpubSubChap434.Name,
			PartOf = EpubVolume43,
			Index = 4,
			LastModifiedAt = 1402965614516L
		};

		public static SoftwareApplication SuperMediaTool = new SoftwareApplication( "https://com.sat/super-media-tool" ) {
			Name = "Super Media Tool",
			LastModifiedAt = 1402965614516L
		};

		public static VideoObject VideoWithLearningObjective = new VideoObject( "https://com.sat/super-media-tool/video/video1" ) {
			Name = "American Revolution - Key Figures Video",
			AlignedLearningObjectives = new[] { 
				new LearningObjective( "http://americanrevolution.com/personalities/learn" )
			},
			Duration = 1420,
			LastModifiedAt = 1402965614516L
		};

		public static MediaLocation VideoWithLearningObjective_Location710 = new MediaLocation( VideoWithLearningObjective.Id ) {
			CurrentTime = 710
		};

		public static SoftwareApplication SuperAssessmentTool = new SoftwareApplication( "https://com.sat/super-assessment-tool" ) {
			Name = "Super Assessment Tool",
			LastModifiedAt = 1402965614516L
		};

		private static string Assessment1_Id = "https://some-university.edu/politicalScience/2014/american-revolution-101/assessment1";

		public static Assessment Assessment1 = new Assessment( Assessment1_Id ) {
			Name = "American Revolution - Key Figures Assessment",
			PartOf = AmRev101.Id,
			DateCreated = 1402965614516L,
			DatePublished = 1402965614516L,
			DateToActivate = 1402965614516L,
			DateToShow = 1402965614516L,
			DateToStartOn = 1402965614516L,
			DateToSubmit = 1402965614516L,
			MaxAttempts = 2,
			MaxSubmits = 2,
			MaxScore = 3.0,
			AssessmentItems = new[] {
				new AssessmentItem( "https://some-university.edu/politicalScience/2014/american-revolution-101/assessment1/item1" ) {
					Name = "Assessment Item 1",
					PartOf = Assessment1_Id,
					MaxAttempts = 2,
					MaxSubmits = 2,
					MaxScore = 1.0
				},
				new AssessmentItem( "https://some-university.edu/politicalScience/2014/american-revolution-101/assessment1/item2" ) {
					Name = "Assessment Item 2",
					PartOf = Assessment1_Id,
					MaxAttempts = 2,
					MaxSubmits = 2,
					MaxScore = 1.0
				},
				new AssessmentItem( "https://some-university.edu/politicalScience/2014/american-revolution-101/assessment1/item3" ) {
					Name = "Assessment Item 3",
					PartOf = Assessment1_Id,
					MaxAttempts = 2,
					MaxSubmits = 2,
					MaxScore = 1.0
				}
			},
			LastModifiedAt = 1402965614516L
		};

		public static Attempt Assessment1_Attempt1 = new Attempt( Assessment1_Id + "/attempt1" ) {
			Assignable = Assessment1,
			Actor = Student554433,
			Count = 1
		};

		public static Result Assessment1_Attempt1_Result = new Result( Assessment1_Attempt1.Id + "/result" ) {
			NormalScore = 3.0,
			PenaltyScore = 0.0,
			ExtraCreditScore = 0.0,
			TotalScore = 3.0,
			CurvedTotalScore = 3.0,
			CurveFactor = 0.0,
			Comment = "Well done.",
		//	ScoredBy = SuperAssessmentTool,
			LastModifiedAt = 1402965614516L
		};

	}

}