﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace mywebtest1
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the mywebtest1Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("909703af-54bd-403c-a5b6-5e3976e14748")]
    public partial class mywebtest1Repository : RepoGenBaseFolder
    {
        static mywebtest1Repository instance = new mywebtest1Repository();
        mywebtest1RepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        mywebtest1RepositoryFolders.NewTabGoogleChromeAppFolder _newtabgooglechrome;
        mywebtest1RepositoryFolders.NewTabAppFolder _newtab;
        mywebtest1RepositoryFolders.AccenturePortalGoogleChromeAppFolder _accentureportalgooglechrome;

        /// <summary>
        /// Gets the singleton class instance representing the mywebtest1Repository element repository.
        /// </summary>
        [RepositoryFolder("909703af-54bd-403c-a5b6-5e3976e14748")]
        public static mywebtest1Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public mywebtest1Repository() 
            : base("mywebtest1Repository", "/", null, 0, false, "909703af-54bd-403c-a5b6-5e3976e14748", ".\\RepositoryImages\\mywebtest1Repository909703af.rximgres")
        {
            _applicationundertest = new mywebtest1RepositoryFolders.ApplicationUnderTestAppFolder(this);
            _newtabgooglechrome = new mywebtest1RepositoryFolders.NewTabGoogleChromeAppFolder(this);
            _newtab = new mywebtest1RepositoryFolders.NewTabAppFolder(this);
            _accentureportalgooglechrome = new mywebtest1RepositoryFolders.AccenturePortalGoogleChromeAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("909703af-54bd-403c-a5b6-5e3976e14748")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("bd61cb0b-5018-49a1-96b0-539f1435bcfb")]
        public virtual mywebtest1RepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The NewTabGoogleChrome folder.
        /// </summary>
        [RepositoryFolder("e09ad081-70a8-451c-b06c-1d4c04b9757c")]
        public virtual mywebtest1RepositoryFolders.NewTabGoogleChromeAppFolder NewTabGoogleChrome
        {
            get { return _newtabgooglechrome; }
        }

        /// <summary>
        /// The NewTab folder.
        /// </summary>
        [RepositoryFolder("5d847b62-4667-41bb-9cda-fdccb1345768")]
        public virtual mywebtest1RepositoryFolders.NewTabAppFolder NewTab
        {
            get { return _newtab; }
        }

        /// <summary>
        /// The AccenturePortalGoogleChrome folder.
        /// </summary>
        [RepositoryFolder("dcd64ea6-dd3d-4604-a3e7-bad00f77b4a9")]
        public virtual mywebtest1RepositoryFolders.AccenturePortalGoogleChromeAppFolder AccenturePortalGoogleChrome
        {
            get { return _accentureportalgooglechrome; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class mywebtest1RepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("bd61cb0b-5018-49a1-96b0-539f1435bcfb")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _requestademoInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.ranorex.com']", parentFolder, 30000, null, false, "bd61cb0b-5018-49a1-96b0-539f1435bcfb", "")
            {
                _requestademoInfo = new RepoItemInfo(this, "RequestADemo", ".//div[#'et_builder_outer_content']/div/div[1]/div/div/div[2]/a[@innertext='Request a demo']", "", 30000, null, "b6b5a860-a108-4e20-be14-a2ff27d0f6d5");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("bd61cb0b-5018-49a1-96b0-539f1435bcfb")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("bd61cb0b-5018-49a1-96b0-539f1435bcfb")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The RequestADemo item.
            /// </summary>
            [RepositoryItem("b6b5a860-a108-4e20-be14-a2ff27d0f6d5")]
            public virtual Ranorex.ATag RequestADemo
            {
                get
                {
                    return _requestademoInfo.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The RequestADemo item info.
            /// </summary>
            [RepositoryItemInfo("b6b5a860-a108-4e20-be14-a2ff27d0f6d5")]
            public virtual RepoItemInfo RequestADemoInfo
            {
                get
                {
                    return _requestademoInfo;
                }
            }
        }

        /// <summary>
        /// The NewTabGoogleChromeAppFolder folder.
        /// </summary>
        [RepositoryFolder("e09ad081-70a8-451c-b06c-1d4c04b9757c")]
        public partial class NewTabGoogleChromeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _addressandsearchbarInfo;

            /// <summary>
            /// Creates a new NewTabGoogleChrome  folder.
            /// </summary>
            public NewTabGoogleChromeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("NewTabGoogleChrome", "/form[@title='New Tab - Google Chrome']", parentFolder, 30000, null, true, "e09ad081-70a8-451c-b06c-1d4c04b9757c", "")
            {
                _addressandsearchbarInfo = new RepoItemInfo(this, "AddressAndSearchBar", "container[@accessiblename='New Tab - Google Chrome']/container[@accessiblename='Google Chrome']/container[2]/container[1]/toolbar[1]/?/?/text[@accessiblename='Address and search bar']", "", 30000, null, "31c169a6-b289-41dc-b765-e116133c02e2");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("e09ad081-70a8-451c-b06c-1d4c04b9757c")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("e09ad081-70a8-451c-b06c-1d4c04b9757c")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The AddressAndSearchBar item.
            /// </summary>
            [RepositoryItem("31c169a6-b289-41dc-b765-e116133c02e2")]
            public virtual Ranorex.Text AddressAndSearchBar
            {
                get
                {
                    return _addressandsearchbarInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The AddressAndSearchBar item info.
            /// </summary>
            [RepositoryItemInfo("31c169a6-b289-41dc-b765-e116133c02e2")]
            public virtual RepoItemInfo AddressAndSearchBarInfo
            {
                get
                {
                    return _addressandsearchbarInfo;
                }
            }
        }

        /// <summary>
        /// The NewTabAppFolder folder.
        /// </summary>
        [RepositoryFolder("5d847b62-4667-41bb-9cda-fdccb1345768")]
        public partial class NewTabAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new NewTab  folder.
            /// </summary>
            public NewTabAppFolder(RepoGenBaseFolder parentFolder) :
                    base("NewTab", "/dom[@domain='newtab']", parentFolder, 30000, null, false, "5d847b62-4667-41bb-9cda-fdccb1345768", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("5d847b62-4667-41bb-9cda-fdccb1345768")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("5d847b62-4667-41bb-9cda-fdccb1345768")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

        /// <summary>
        /// The AccenturePortalGoogleChromeAppFolder folder.
        /// </summary>
        [RepositoryFolder("dcd64ea6-dd3d-4604-a3e7-bad00f77b4a9")]
        public partial class AccenturePortalGoogleChromeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _newtabInfo;

            /// <summary>
            /// Creates a new AccenturePortalGoogleChrome  folder.
            /// </summary>
            public AccenturePortalGoogleChromeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("AccenturePortalGoogleChrome", "/form[@title>'Accenture Portal - Google']", parentFolder, 30000, null, true, "dcd64ea6-dd3d-4604-a3e7-bad00f77b4a9", "")
            {
                _newtabInfo = new RepoItemInfo(this, "NewTab", "container[@accessiblename>'Accenture Portal - Google']/container[@accessiblename='Google Chrome']//button[@accessiblename='New Tab']", "", 30000, null, "b089f70e-91fa-41ac-bc61-e5d378a42e31");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("dcd64ea6-dd3d-4604-a3e7-bad00f77b4a9")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("dcd64ea6-dd3d-4604-a3e7-bad00f77b4a9")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The NewTab item.
            /// </summary>
            [RepositoryItem("b089f70e-91fa-41ac-bc61-e5d378a42e31")]
            public virtual Ranorex.Button NewTab
            {
                get
                {
                    return _newtabInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The NewTab item info.
            /// </summary>
            [RepositoryItemInfo("b089f70e-91fa-41ac-bc61-e5d378a42e31")]
            public virtual RepoItemInfo NewTabInfo
            {
                get
                {
                    return _newtabInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}