﻿/*==============================================================================================================================
| Author        Ignia, LLC
| Client        Ignia, LLC
| Project       Topics Library
\=============================================================================================================================*/
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ignia.Topics.Mapping;
using Ignia.Topics.Repositories;
using Ignia.Topics.Models;
using Ignia.Topics.AspNetCore.Mvc.Models;
using Ignia.Topics.ViewModels;
using Ignia.Topics.AspNetCore.Mvc.Components;
using Ignia.Topics;

namespace OnTopicTest.Components {

  /*============================================================================================================================
  | CLASS: PAGE-LEVEL NAVIGATION VIEW COMPONENT
  \---------------------------------------------------------------------------------------------------------------------------*/
  /// <summary>
  ///   Defines a <see cref="ViewComponent"/> which provides access to a menu of <typeparamref name="NavigationTopicViewModel"/>
  ///   instances representing the nearest page-level navigation.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///     As a best practice, global data required by the layout view are requested independent of the current page. This
  ///     allows each layout element to be provided with its own layout data, in the form of <see
  ///     cref="NavigationViewModel{T}"/>s, instead of needing to add this data to every view model returned by <see
  ///     cref="TopicController"/>.
  ///   </para>
  /// </remarks>
  public class PageLevelNavigationViewComponent : PageLevelNavigationViewComponentBase<NavigationTopicViewModel> {

    /*==========================================================================================================================
    | CONSTRUCTOR
    \-------------------------------------------------------------------------------------------------------------------------*/
    /// <summary>
    ///   Initializes a new instance of a <see cref="MenuViewComponentBase{T}"/> with necessary dependencies.
    /// </summary>
    /// <returns>A topic controller for loading OnTopic views.</returns>
    public PageLevelNavigationViewComponent(
      ITopicRoutingService topicRoutingService,
      IHierarchicalTopicMappingService<NavigationTopicViewModel> hierarchicalTopicMappingService
    ) : base(
      topicRoutingService,
      hierarchicalTopicMappingService
    ) {}

  } // Class

} // Namespace