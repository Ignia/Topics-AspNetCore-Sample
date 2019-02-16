/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Sample OnTopic Site
\=============================================================================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTopicTest.Models {

  /*============================================================================================================================
  | INTERFACE: CARD VIEW MODEL
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Ensures that a <see cref="TopicViewModel"/> meets the base requirements for being treated as a card.
  /// </summary>
  public interface ICardViewModel {

    string ThumbnailImage { get; }
    string WebPath { get; }
    string Title { get; }

  } // Interface

} // Namespace
