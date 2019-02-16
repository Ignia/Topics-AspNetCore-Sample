/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Sample OnTopic Site
\=============================================================================================================================*/
using Ignia.Topics.ViewModels;

namespace OnTopicTest.Models {

  /*============================================================================================================================
  | VIEW MODEL: MODULE PAGE TOPIC
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Provides a strongly-typed data transfer object for feeding views with information about a <c>ModulePage</c>
  ///   topic.
  /// </summary>
  public class ModulePageTopicViewModel : PageTopicViewModel, ICardViewModel {

    public string ThumbnailImage { get; set; }

  } // Class

} // Namespace
