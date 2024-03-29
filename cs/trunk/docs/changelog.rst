.. -*- coding: UTF-8 -*-

:Subtitle: All you wanted to know and much, much more...

.. _changelog:

Change Log
==========

Version Index
-------------
* `v2.9.2 - 06 June 2016`_
* `v2.9.1 - 05 May 2016`_
* `v2.9.0 - 11 November 2015`_
* `v2.8.1 - 26 January 2015`_
* `v2.8 - 13 October 2014`_
* `v2.7 - 28 February 2014`_
* `v2.6 - 01 November 2012`_
* `v2.5 - 06 June 2011`_
* `v2.4.1 - 15 September 2010`_
* `v2.4 - 17 April 2010`_
* `v2.3 - 14 October 2009`_
* `v2.2.1 - 08 August 2009`_
* `v2.2 - 08 June 2009`_
* `v2.2 beta - 15 May 2009`_
* `v2.1 - 26 February 2009`_
* `v2.1a - 07 February 2009`_
* `v2.0.1 - 10 January 2009`_
* `v2.0 - 30 November 2008`_
* `v1.13 - 24 July 2008`_


v2.9.2 - 06 June 2016
---------------------

2016-06-02 12:47 (#816) - ObjectListView/ObjectListView.cs
  - Cell editors now respond to mouse wheel events. Set AllowCellEditorsToProcessMouseWheel to false revert to previous behaviour.
  - Fixed issue in PauseAnimations() that prevented it from working until after the control had been rendered at least once.
  - cellEditUseWholeCell now has correct default value (true).
  - Dropping on a subitem when CellEditActivation is set to SingleClick no longer  initiates a cell edit
  - Fix spelling mistakes

2016-06-02 12:45 (#815) - ObjectListView/TreeListView.cs
  - Added bounds check to GetNthObject()
  - Fix spelling mistakes

2016-06-02 12:44 (#814) - ObjectListView/VirtualObjectListView.cs, ObjectListView/DataTreeListView.cs, ObjectListView/OLVColumn.cs, ObjectListView/ObjectListView.DesignTime.cs
  - Fix spelling mistakes

2016-06-02 12:42 (#813) - ObjectListView/Utilities/TypedObjectListView.cs, ObjectListView/Utilities/ColumnSelectionForm.cs, ObjectListView/Utilities/Generator.cs
  - Fix spelling mistakes

2016-06-02 12:39 (#812) - ObjectListView/SubControls/ToolTipControl.cs, ObjectListView/SubControls/GlassPanelForm.cs, ObjectListView/SubControls/HeaderControl.cs
  - Fix spelling mistakes

2016-06-02 12:39 (#811) - ObjectListView/Rendering/Renderers.cs
  - CalculateImageWidth() no longer adds 2 to the image width
  - Fix calculation of cell edit boundaries on TreeListView controls
  - Fix some spelling mistakes

2016-06-02 12:37 (#810) - ObjectListView/Rendering/Styles.cs, ObjectListView/Rendering/Adornments.cs, ObjectListView/Rendering/Decorations.cs
  - Fix spelling mistakes

2016-06-02 12:37 (#809) - ObjectListView/Filtering/TextMatchFilter.cs, ObjectListView/Filtering/ClusteringStrategy.cs, ObjectListView/Implementation/Attributes.cs, ObjectListView/Implementation/TreeDataSourceAdapter.cs, ObjectListView/Implementation/Munger.cs, ObjectListView/Implementation/NativeMethods.cs, ObjectListView/CellEditing/CellEditors.cs, ObjectListView/Implementation/Events.cs, ObjectListView/CellEditing/CellEditKeyEngine.cs, ObjectListView/Filtering/DateTimeClusteringStrategy.cs, ObjectListView/Implementation/OLVListItem.cs, ObjectListView/Implementation/OLVListSubItem.cs, ObjectListView/DragDrop/DropSink.cs, ObjectListView/DragDrop/OLVDataObject.cs, ObjectListView/Filtering/FilterMenuBuilder.cs, ObjectListView/DragDrop/DragSource.cs, ObjectListView/Implementation/VirtualGroups.cs
  - Fix spelling mistakes

2016-06-02 12:35 (#808) - ListViewPrinter/ListViewPrinter.cs
  - Fix some spelling mistakes



v2.9.1 - 05 May 2016
--------------------

2016-05-05 23:56 (#806) - docs/recipes.rst
  - Correct small typo

2016-05-05 23:50 (#805) - docs/Help/ObjectListView-Documentation.chm
  - v2.9.1 help

2016-05-05 22:38 (#804) - ObjectListView/Properties/AssemblyInfo.cs, ObjectListView/Implementation/Delegates.cs, ObjectListView/Implementation/OLVListSubItem.cs, ObjectListView/ObjectListView.cs, ObjectListView/ObjectListView2012.nuspec, ObjectListView/CellEditing/CellEditKeyEngine.cs
  - v2.9.1
  - Added CellRendererGetter to allow each cell to have a different renderer.
  - Obsolete properties are no longer code-gen'ed.
  - Fixed a few small bugs

2016-05-05 22:37 (#803) - ListViewPrinter/ListViewPrinter.cs
  - ListViewPrinter now requires ObjectListView
  - Uses correct renderer for each cell



v2.9.0 - 11 November 2015
-------------------------

2015-11-07 13:33 (#801) - ObjectListView/Properties/AssemblyInfo.cs, ObjectListView/Implementation/DataSourceAdapter.cs, Tests/packages.config, docs/recipes.rst, Demo/TabTreeListView.cs, ObjectListView2012.sln.DotSettings, ObjectListView2010.sln.DotSettings, ObjectListView/ObjectListView.cs, docs/.templates/layout.html, ObjectListView/ObjectListView2012.nuspec, docs/features.rst, ObjectListView/FastObjectListView.cs, docs/whatsnew.rst, ObjectListView/ObjectListView2012.csproj, Demo/Properties/AssemblyInfo.cs, ObjectListView/ObjectListView2005.csproj, docs/conf.py, Tests/Tests2012.csproj, ObjectListView2012.v2.ncrunchsolution, ObjectListView/ObjectListView.shfb, ObjectListView2012.sln
  - Prepare v2.9

2015-08-25 22:53 (#800) - packages/NUnit.2.6.4/lib/nunit.framework.dll, docs/images/button-states.png, docs/images/buttons-hot.png, docs/images/described-task-row.png, docs/images/buttons-pressed.png, docs/images/described-task-2.png, docs/images/buttons-1.png, ObjectListView/ObjectListView2012.nuspec, ObjectListView/ObjectListView2012.sln.DotSettings, docs/images/described-task1.png
  - Add new files

2015-08-25 22:50 (#799) - Tests/TestNotifications.cs, Tests/TestTreeView.cs, Tests/MainForm.Designer.cs, Tests/Program.cs, Tests/TestExport.cs
  - Added more tests

2015-08-25 22:50 (#798) - ObjectListView/TreeListView.cs
  - Fixed buy with hierarchical checkboxes where setting the checkedness of a deeply nested object would sometimes not correctly calculate the changes in the hierarchy. SF #150.
  - Added more docs for CanExpandGetter and ChildrenGetter

2015-08-25 22:49 (#797) - ObjectListView/SubControls/HeaderControl.cs
  - Make sure header is owner drawn when the first column isnt left aligned

2015-08-25 22:47 (#796) - ObjectListView/Rendering/TreeRenderer.cs
  - Added TreeRenderer.UseTriangles and IsShowGlyphs

2015-08-25 22:46 (#795) - ObjectListView/Rendering/Renderers.cs
  - Allow selected row back/fore colours to be specified for each row
  - Added ColumnButtonRenderer plus general support for Buttons

2015-08-25 22:44 (#794) - ObjectListView/Properties/AssemblyInfo.cs
  - Update version to 2.9.0-beta1

2015-08-25 22:43 (#793) - ObjectListView/OLVColumn.cs
  - Added button support

2015-08-25 22:25 (#792) - ObjectListView/ObjectListView.DesignTime.cs, ObjectListView/ObjectListView.cs
  - Allow selected row back/fore colours to be specified for each row
  - Renamed properties related to selection colours:
  - - HighlightBackgroundColor -> SelectedBackColor
  - - HighlightForegroundColor -> SelectedForeColor
  - - UnfocusedHighlightBackgroundColor -> UnfocusedSelectedBackColor
  - - UnfocusedHighlightForegroundColor -> UnfocusedSelectedForeColor
  - UseCustomSelectionColors is no longer used
  - Added ObjectListView.CellEditFinished event
  - All ObjectListViews are now OwnerDrawn by default.

2015-08-25 22:21 (#791) - ObjectListView/Implementation/OLVListItem.cs
  - Added OLVListItem.SelectedBackColor and SelectedForeColor

2015-08-25 22:21 (#790) - ObjectListView/Implementation/Events.cs
  - Added CellEditFinished

2015-08-25 22:19 (#789) - ObjectListView/FastObjectListView.cs, ObjectListView/Implementation/VirtualListDataSource.cs, ObjectListView/VirtualObjectListView.cs
  - Added InsertObjects to VirtualObjectListView. This allows rearranging for *some* subclasses

2015-08-25 22:17 (#788) - ObjectListView/DragDrop/DropSink.cs
  - Added SimpleDropSink.EnableFeedback to allow all the pretty and helpful user feedback during drags to be turned off

2015-08-25 22:16 (#787) - ObjectListView/CellEditing/EditorRegistry.cs
  - Added EditorRegistry.Unregister()

2015-08-25 22:15 (#786) - ListViewPrinterDemo/Form1.resx, ListViewPrinterDemo/Properties/AssemblyInfo.cs, ListViewPrinterDemo/Form1.cs, ListViewPrinterDemo/Form1.Designer.cs
  - Changed to use ObjectListView rather than plain ListView

2015-08-25 22:13 (#785) - docs/features.rst, docs/whatsnew.rst, docs/index.rst, docs/conf.py, docs/recipes.rst, docs/faq.rst, docs/.templates/layout.html, docs/download.rst, docs/changelog.rst
  - Updated docs preparing for v2.9

2015-08-25 22:12 (#784) - Demo/TabFastList.cs, Demo/TabDataTreeListView.Designer.cs, Demo/TabFastList.Designer.cs, Demo/TabSimpleExample.Designer.cs, Demo/TabComplexExample.Designer.cs, Demo/TabComplexExample.cs, Demo/TabTreeListView.resx, Demo/TabDragAndDrop.cs, Demo/TabTreeListView.cs, Demo/TabDataSet.cs, Demo/TabFileExplorer.resx, Demo/TabTreeListView.Designer.cs, Demo/TabDragAndDrop.Designer.cs, Demo/OLVDemoCoordinator.cs, Demo/MainForm.resx, Demo/TabFileExplorer.cs, Demo/TabDataSet.Designer.cs, Demo/TabFileExplorer.Designer.cs, Demo/TabDescribedTask.cs, Demo/BusinessCardRenderer.cs, Demo/MainForm.cs, Demo/TabDescribedTask.Designer.cs, Demo/TabComplexExample.resx, Demo/TabDragAndDrop.resx, Demo/MainForm.Designer.cs, Demo/TabFastList.resx, Demo/TabDataSet.resx
  - Remove checkboxes that controlled owner drawing, since ObjectListView is now always owner drawn

2015-08-25 22:11 (#783) - ObjectListView/Utilities/TypedObjectListView.cs, ObjectListView/Filtering/TextMatchFilter.cs, ObjectListView/Implementation/NullableDictionary.cs, Demo/AnimatedDecoration.cs, ObjectListView/Filtering/ClusteringStrategy.cs, SparkleLibrary/Locators/RectangleLocator.cs, ObjectListView/Implementation/Attributes.cs, SparkleLibrary/Sprites/Audio.cs, ObjectListView/Filtering/IClusteringStrategy.cs, ObjectListView/Implementation/Comparers.cs, ObjectListView/Filtering/ICluster.cs, ObjectListView/Implementation/GroupingParameters.cs, ObjectListView/Implementation/NativeMethods.cs, SparkleLibrary/Animation/Animation.cs, ObjectListView/CellEditing/CellEditors.cs, ObjectListView/Implementation/Groups.cs, ObjectListView/CellEditing/CellEditKeyEngine.cs, SparkleLibrary/Sprites/ShapeSprite.cs, ObjectListView/Rendering/Overlays.cs, ObjectListView/Implementation/Delegates.cs, ObjectListView/DataListView.cs, SparkleLibrary/Locators/Locators.cs, SparkleLibrary/Animation/Animateable.cs, ObjectListView/Implementation/OLVListSubItem.cs, ObjectListView/SubControls/GlassPanelForm.cs, ObjectListView/Rendering/Decorations.cs, ObjectListView/DragDrop/OLVDataObject.cs, ObjectListView/Implementation/VirtualGroups.cs, ObjectListView/Filtering/FlagClusteringStrategy.cs, ObjectListView/Implementation/OlvListViewHitTestInfo.cs, ObjectListView/Implementation/DataSourceAdapter.cs, ObjectListView/Rendering/Styles.cs, ObjectListView/Utilities/OLVExporter.cs, SparkleLibrary/Sprites/TextSprite.cs, ObjectListView/Filtering/Filters.cs, ObjectListView/Filtering/ClustersFromGroupsStrategy.cs, ObjectListView/Implementation/Munger.cs, SparkleLibrary/Animation/Events.cs, SparkleLibrary/Effects/Effects.cs, SparkleLibrary/Sprites/ImageSprite.cs, ObjectListView/Utilities/Generator.cs, SparkleLibrary/Sprites/ISprite.cs, ObjectListView/Filtering/DateTimeClusteringStrategy.cs, ObjectListView/DataTreeListView.cs, ObjectListView/SubControls/ToolStripCheckedListBox.cs, ObjectListView/FastDataListView.cs, ObjectListView/Rendering/Adornments.cs, SparkleLibrary/Locators/PointLocator.cs, ObjectListView/Implementation/Enums.cs, ObjectListView/Filtering/Cluster.cs, ObjectListView/SubControls/ToolTipControl.cs, SparkleLibrary/Effects/Effect.cs, ObjectListView/Filtering/FilterMenuBuilder.cs, ListViewPrinter/ListViewPrinter.cs, SparkleLibrary/Adapters/AnimationAdapter.cs, SparkleLibrary/Sprites/Sprite.cs, ObjectListView/DragDrop/DragSource.cs
  - Change email address to gmail

2015-07-04 01:33 (#781) - packages/NUnit.2.6.4/lib/nunit.framework.xml, packages/NUnit.2.6.4/lib, packages/NUnit.2.6.4, packages/NUnit.2.6.4/NUnit.2.6.4.nupkg, packages/NUnit.2.6.4/license.txt
  - Added Nunit package

2015-07-04 01:31 (#780) - ObjectListView/Utilities/Generator.cs
  - Columns without [OLVColumn] now auto size

2015-07-04 01:30 (#779) - ObjectListView/SubControls/HeaderControl.cs
  - Use MinimumHeight as well as MaximumHeight
  - Use HeaderTextAlignOrDefault instead of HeaderTextAlign

2015-07-04 01:29 (#778) - ObjectListView/Rendering/Renderers.cs, ObjectListView/Rendering/TreeRenderer.cs
  - Added ColumnButtonRenderer to draw buttons in cells
  - Improved hit testing
  - Added BaseRenderer.ConfigureItem() and ConfigureSubItem() to easily allow other renderers to be chained for use within a primary renderer.
  - Handle renderering an Image when that Image is returned as an aspect.

2015-07-04 01:23 (#777) - ObjectListView/Properties/AssemblyInfo.cs, ObjectListView/Properties/Resources.Designer.cs
  - Update version to 2.9.0 alpha

2015-07-04 01:21 (#776) - ObjectListView/Implementation/OlvListViewHitTestInfo.cs, ObjectListView/Implementation/OLVListItem.cs, ObjectListView/Implementation/Events.cs
  - Added support for buttons

2015-07-04 01:20 (#775) - ObjectListView/Implementation/Delegates.cs
  - Added SearchValueGetter delegate

2015-07-04 01:19 (#774) - ObjectListView/Implementation/DataSourceAdapter.cs
  - Made CreateColumnsFromSource() only rebuild columns when new ones were added

2015-07-04 01:18 (#773) - ObjectListView/Filtering/TextMatchFilter.cs, ObjectListView/Filtering/Filters.cs
  - TextMatchFilter can now search multiple strings from the same cell
  - Added CompositeFilter.TextFilters

2015-07-04 01:15 (#772) - ObjectListView/VirtualObjectListView.cs
  - Moved handling of CheckBoxes on virtual lists into base class (ObjectListView).
  - Subscribe to change notifications when objects are added

2015-07-04 01:14 (#771) - ObjectListView/TreeListView.cs
  - Corrected small UI glitch when focus was lost and HideSelection was false. SF #135.

2015-07-04 01:13 (#770) - ObjectListView/OLVColumn.cs
  - Added SearchValueGetter, which returns the strings to be considered for searching
  - Added CellEditUseWholeCell property
  - Added EnableButtonWhenItemIsDisabled property
  - HeaderTextAlignment became nullable so that it can be "not set" (this was always the intent)

2015-07-04 01:04 (#769) - ObjectListView/ObjectListView.cs
  - v2.9 alpha
  - Yet another attempt to disable ListView's "shift click toggles checkboxes" behaviour.
  - Trigger SelectionChanged when filter is changed
  - Added OLVColumn.SearchValueGetter to allow the text used when text filtering to be customised
  - The default DefaultRenderer is now a HighlightTextRenderer, since that seems more generally useful
  - Hot item is now always applied to the row even if FullRowSelect is false
  - Added DefaultHotItemStyle property
  - Added HeaderMinimumHeight property
  - Added ObjectListView.CellEditUsesWholeCell and OLVColumn.CellEditUsesWholeCell properties.
  - Allow ImageGetter to return an Image (which I can't believe didn't work from the beginning!)
  - Fix bug where setting View to LargeIcon in the designer was not persisted
  - Ensure changes to row.Font in FormatRow are not wiped out by FormatCell (SF #141)

2015-07-04 01:02 (#768) - ObjectListView/FastObjectListView.cs
  - Fix issue with RemoveObjects() where objects were removed too early

2015-07-04 01:00 (#767) - ObjectListView/FastDataListView.cs
  - Made Unfreezing more efficient by removing a redundant BuildList() call

2015-07-04 00:59 (#766) - ObjectListView/DataTreeListView.cs
  - Expose AutoGenerateColumns property

2015-07-04 00:59 (#765) - ObjectListView/DataListView.cs
  - Made Unfreezing more efficient by removing a redundant BuildList() call

2015-07-04 00:56 (#764) - Tests/TestFormatting.cs, Tests/packages.config, Tests/Tests2012.csproj
  - Test for formatting priority

2015-07-04 00:47 (#763) - Demo/TabDataTreeListView.cs, Demo/TabFastList.cs, Demo/AnimatedDecoration.cs, Demo/Models/MyFileSystemInfo.cs, Demo/ObjectListViewDemo2010.csproj, Demo/TabFastList.Designer.cs, Demo/ObjectListViewDemo2012.csproj, Demo/TabSimpleExample.Designer.cs, Demo/TabComplexExample.Designer.cs, Demo/Properties/Resources.resx, Demo/TabPrinting.resx, Demo/ObjectListViewDemo2005.csproj, Demo/ObjectListViewDemo2008.csproj, Demo/TabPrinting.cs, Demo/TabFileExplorer.resx, Demo/TabTreeListView.Designer.cs, Demo/TabPrinting.Designer.cs, Demo/ShellUtilities.cs, Demo/OLVDemoCoordinator.cs, Demo/MainForm.resx, Demo/TabFileExplorer.cs, Demo/TabDataSet.Designer.cs, Demo/TabFileExplorer.Designer.cs, Demo/AnimatedGifs, Demo/Properties/Resource1.Designer.cs, Demo/Properties/Resources.Designer.cs, Demo/TabSimpleExample.resx, Demo/Models/MaritalStatus.cs, Demo/MainForm.cs, Demo/TabComplexExample.resx, Demo/BusinessCardOverlay.cs, Demo/MainForm.Designer.cs, Demo/OlvDemoTab.cs, Demo/TabSimpleExample.cs, Demo/TabDataTreeListView.Designer.cs, Demo/Person.cs, Demo/Properties/Resource1.resx, Demo/TabTreeListView.resx, Demo/TabComplexExample.cs, Demo/TabDragAndDrop.cs, Demo/TabTreeListView.cs, Demo/TabDescribedTask.resx, Demo/TabDataSet.cs, Demo/TabDragAndDrop.Designer.cs, Demo/Models/Person.cs, Demo/Properties/AssemblyInfo.cs, Demo/TabDescribedTask.cs, Demo/BusinessCardRenderer.cs, Demo/MyFileSystemInfo.cs, Demo/Data/Persons.xml, Demo/TabDescribedTask.Designer.cs, Demo/Models, Demo/TabDragAndDrop.resx, Demo/Data, Demo/TabDataTreeListView.resx, Demo/TabFastList.resx, Demo/Data/FamilyTree.xml, Demo/TabDataSet.resx
  - New improved demo for v2.9



v2.8.1 - 26 January 2015
------------------------

2015-01-26 18:27 (#761) - Tests/NUnit.2.6.2/lib/nunit.framework.dll
  - Add missing dll

2015-01-26 17:31 (#760) - docs/whatsnew.rst, docs/conf.py
  - Check in changes to docs for v2.8.1

2015-01-26 17:04 (#759) - ObjectListView/Properties/AssemblyInfo.cs, ObjectListView/TreeListView.cs, ObjectListView/Implementation/Delegates.cs, ObjectListView/Implementation/Comparers.cs
  - Allow string comparisons to be replaced via static properties `ModelObjectComparer.StringComparer` and `ColumnComparer.StringComparer`
  - Fixed issue in RefreshObject() where a model with less children than previous that could not longer be expanded would cause an exception.

2014-11-23 18:33 (#758) - docs/filtering.rst, docs/whatsnew.rst, docs/cellEditing.rst, Demo/AssemblyInfo.cs, docs/.templates/layout.html
  - Updated docs for 2.8.1

2014-11-23 18:30 (#757) - ObjectListView/Properties/AssemblyInfo.cs, ObjectListView/FastObjectListView.cs, ObjectListView/VirtualObjectListView.cs, ObjectListView/TreeListView.cs, ObjectListView/ObjectListView2012.csproj, ObjectListView/Implementation/Enums.cs, ObjectListView/Rendering/Renderers.cs, ObjectListView/Implementation/Events.cs, ObjectListView/ObjectListView.cs, ObjectListView/ObjectListView2012.nuspec
  - Fixed issue where single-click editing didn't work (SF #128)
  - Added CellEditActivateMode.SingleClickAlways mode
  - Fire Filter event event if ModelFilter and ListFilter are null (SF #126)
  - Fixed issue in TreeListView where wrong objects were selected after collapsing a branch
  - Updated to v2.8.1

2014-11-23 18:27 (#756) - ObjectListView/Implementation/DataSourceAdapter.cs, ObjectListView/DataListView.cs, ObjectListView/FastDataListView.cs
  - Honour initial CurrencyManager.Position when setting DataSource.
  - Fix issue where SelectedObject was not sync'ed with CurrencyManager.Position (SF #129)
  - Correctly dispose of data adapters



v2.8 - 13 October 2014
----------------------

2014-10-13 22:16 (#755) - Tests/NUnit.2.6.2/license.txt, Tests/packages.config, Tests/Tests2012.csproj, Tests/NUnit.2.6.2/lib/nunit.framework.xml, Demo/MainForm.cs, ObjectListView/SubControls/HeaderControl.cs, Tests/NUnit.2.6.2/lib, Tests/NUnit.2.6.2
  - Fix issue with disposing of header tooltip
  - Include NUnit DLL with Tests project to remove dependency on NuGet
  - Fix some .NET 2.0 issues in demo

2014-10-13 22:00 (#754) - ObjectListView/Implementation/DataSourceAdapter.cs, ObjectListView/TreeListView.cs, docs/blog8.rst, ObjectListView2012.sln.DotSettings, docs/.templates/layout.html, docs/changelog.rst
  - Minor documentation tweaks

2014-10-11 19:14 (#753) - ObjectListView/VirtualObjectListView.cs, ObjectListView/TreeListView.cs, ObjectListView/ObjectListView.cs
  - Fixed some XP-only flicker issues

2014-10-11 19:13 (#752) - ObjectListView, docs/whatsnew.rst, , docs/conf.py, docs/recipes.rst, docs/.templates/layout.html, docs/download.rst, ObjectListView/ObjectListView2012.nuspec, ObjectListView2012.sln, docs/changelog.rst, docs/gettingStarted.rst
  - Update docs ready for v2.8

2014-10-08 22:45 (#751) - ObjectListView/ObjectListView2012.nuspec, ObjectListView2012.sln
  - Small environment changes

2014-10-08 22:43 (#750) - ObjectListView/TreeListView.cs
  - Fixed an issue where pre-expanded branches would not initially expand properly
  - Fixed issue where RefreshObject() on a root object could cause exceptions
  - Fixed issue where CollapseAll() while filtering could cause exception

2014-10-08 22:41 (#749) - ObjectListView/Utilities/ColumnSelectionForm.cs
  - Fixed issue where rearranging columns on the form would not be persisted

2014-10-08 22:34 (#748) - ObjectListView/Rendering/Renderers.cs
  - Dispose of animation timer in a more robust fashion.

2014-10-08 22:08 (#747) - ObjectListView/Implementation/OLVListItem.cs, ObjectListView/ObjectListView.cs
  - Fixed intricate bug involving checkboxes on non-owner-drawn virtual lists.
  - Fixed long standing (but previously unreported) error on non-details virtual lists where users could not clicked on checkboxes.
  - Remove faulty caching of OLVListItem.CheckState

2014-10-08 22:06 (#746) - ObjectListView/VirtualObjectListView.cs
  - Correct an incorrect use of checkStateMap when setting CheckedObjects and a CheckStateGetter is installed

2014-10-08 22:04 (#745) - docs/filtering.rst, docs/whatsnew.rst, docs/recipes.rst, Demo/MainForm.cs, docs/download.rst
  - Updated documentation for v2.8 - little by little ...

2014-10-08 22:03 (#744) - ObjectListView/Implementation/NativeMethods.cs
  - Avoid errors on 64-bit machines caused by dumb casting to int

2014-09-18 02:40 (#743) - ObjectListView/Properties/AssemblyInfo.cs, ObjectListView/Implementation/OlvListViewHitTestInfo.cs, Tests/TestGenerator.cs, ObjectListView/VirtualObjectListView.cs, packages/NUnit.2.6.2/lib/nunit.framework.xml, ObjectListView/OLVColumn.cs, Tests/TestTreeView.cs, ObjectListView/Implementation/NativeMethods.cs, ObjectListView/Rendering/Renderers.cs, ObjectListView/Implementation/Events.cs, ObjectListView/SubControls/HeaderControl.cs, ObjectListView/ObjectListView.cs
  - (Major) Added ability to have checkboxes in headers
  - CellOver events are raised when the mouse moves over the header. Set TriggerCellOverEventsWhenOverHeader to false to disable this behaviour.
  - Freeze/Unfreeze now use BeginUpdate/EndUpdate to disable Window level drawing
  - Added CheckAll() and UncheckAll() commands
  - Changed default value of ObjectListView.HeaderUsesThemes from true to false.
  - Final attempt to fix the multiple hyperlink events being raised. This involves turning a NM_CLICK notification into a NM_RCLICK.
  - Forecolor on cells are now correctly initialized before FormatCell event is raised
  - Fixed flickering of virtual lists issue on XP
  - OLVColumns now raise VisibilityChanged events

2014-09-18 02:25 (#742) - ObjectListView/TreeListView.cs
  - TreeListView.CollapseAll() now actually, you know, collapses all

2014-09-18 02:23 (#741) - ObjectListView/FastDataListView.cs
  - Exposed FastDataListView.AutoGenerateColumns

2014-09-18 02:21 (#740) - , packages, ObjectListView/ObjectListView2010.ncrunchproject, ObjectListView/ObjectListView2012.ncrunchproject, packages/NUnit.2.6.2/lib, Demo/ObjectListViewDemo2010.ncrunchproject, docs/recipes.rst, Demo/ObjectListViewDemo2012.ncrunchproject, ObjectListView/ObjectListView2008.ncrunchproject, SparkleLibrary/SparkleLibrary2012.csproj, ObjectListView2010.sln.DotSettings, ObjectListView2012.sln.DotSettings, SparkleLibrary/SparkleLibrary2012.v2.ncrunchproject, packages/NUnit.2.6.2/NUnit.2.6.2.nupkg, ObjectListView2012.v2.ncrunchsolution, ObjectListView/ObjectListView2012.v2.ncrunchproject, ListViewPrinter/ListViewPrinter2012.v2.ncrunchproject, SparkleLibrary/SparkleLibrary2010.ncrunchproject, ListViewPrinterDemo/ListViewPrinterDemo2012.v2.ncrunchproject, SparkleLibrary/SparkleLibrary2012.ncrunchproject, packages/NUnit.2.6.2/NUnit.2.6.2.nuspec, .nuget/NuGet.targets, Tests/Tests2012.v2.ncrunchproject, ListViewPrinter/Properties/AssemblyInfo.cs, docs, packages/NUnit.2.6.2/license.txt, .nuget/NuGet.Config, ObjectListView/ObjectListView2012.nuspec, packages/repositories.config, Demo/ObjectListViewDemo2012.v2.ncrunchproject, docs/whatsnew.rst, ListViewPrinter/ListViewPrinter2010.ncrunchproject, ObjectListView2010.ncrunchsolution, ObjectListView2012.ncrunchsolution, ObjectListView/ObjectListView2012.csproj, ListViewPrinter/ListViewPrinter2012.ncrunchproject, ListViewPrinterDemo/ListViewPrinterDemo2010.ncrunchproject, packages/NUnit.2.6.2/lib/nunit.framework.dll, docs/index.rst, ListViewPrinterDemo/ListViewPrinterDemo2012.ncrunchproject, packages/NUnit.2.6.2, docs/images/column-headercheckbox-1.png, Tests/Tests2012.csproj, Tests/Tests2010.ncrunchproject, Tests/Tests2012.ncrunchproject, ObjectListView2012.sln, .nuget
  - Added VS 2012
  - Added support for NCrunch
  - Added Nuget

2014-09-18 02:16 (#739) - Demo/AssemblyInfo.cs, Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Small tweaks prior to v2.8

2014-06-04 20:53 (#738) - Demo/AssemblyInfo.cs
  - Update copyright

2014-06-04 20:35 (#737) - ObjectListView/Utilities/TypedObjectListView.cs, ObjectListView/Filtering/TextMatchFilter.cs, ObjectListView/Implementation/NullableDictionary.cs, ObjectListView/Implementation/VirtualListDataSource.cs, ObjectListView/Filtering/ClusteringStrategy.cs, ObjectListView/Implementation/Attributes.cs, ObjectListView/Filtering/IClusteringStrategy.cs, ObjectListView/Implementation/Comparers.cs, ObjectListView/Filtering/ICluster.cs, ObjectListView/Implementation/GroupingParameters.cs, ObjectListView/CellEditing/EditorRegistry.cs, ObjectListView/CellEditing/CellEditors.cs, ObjectListView/Implementation/Groups.cs, ObjectListView/Rendering/Overlays.cs, ObjectListView/DataListView.cs, ObjectListView/Implementation/Delegates.cs, ObjectListView/OLVColumn.cs, ObjectListView/DragDrop/DropSink.cs, ObjectListView/SubControls/GlassPanelForm.cs, ObjectListView/Implementation/OLVListSubItem.cs, ObjectListView/ObjectListView.DesignTime.cs, ObjectListView/Rendering/Decorations.cs, ObjectListView/Implementation/VirtualGroups.cs, ObjectListView/Implementation/OlvListViewHitTestInfo.cs, ObjectListView/TreeListView.cs, ObjectListView/Implementation/DataSourceAdapter.cs, ObjectListView/Filtering/Filters.cs, ObjectListView/Filtering/ClustersFromGroupsStrategy.cs, ObjectListView/Implementation/TreeDataSourceAdapter.cs, ObjectListView/Implementation/Munger.cs, ObjectListView/Utilities/Generator.cs, ObjectListView/Filtering/DateTimeClusteringStrategy.cs, ObjectListView/FastObjectListView.cs, ObjectListView/VirtualObjectListView.cs, ObjectListView/SubControls/ToolStripCheckedListBox.cs, ObjectListView/ObjectListView2012.csproj, ObjectListView/FastDataListView.cs, ObjectListView/Rendering/Adornments.cs, ObjectListView/Implementation/Enums.cs, ObjectListView/Filtering/Cluster.cs, ObjectListView/SubControls/ToolTipControl.cs, ObjectListView/SubControls/HeaderControl.cs, ObjectListView/Filtering/FilterMenuBuilder.cs, ObjectListView/DragDrop/DragSource.cs
  - Update copyright

2014-06-04 20:34 (#736) - ObjectListView/ObjectListView.cs
  - Added ability to disable rows. DisabledObjects, DisableObjects(), DisabledItemStyle

2014-06-04 20:32 (#735) - ObjectListView/Rendering/Styles.cs, ObjectListView/Rendering/Renderers.cs
  - Added support for disabled rows

2014-06-04 20:30 (#734) - ObjectListView/Implementation/Events.cs
  - Added IsHyperlinkEventArgs.IsHyperlink

2014-06-04 20:29 (#733) - ObjectListView/Implementation/NativeMethods.cs
  - Added DeselectOneItem
  - Added new imagelist drawing code

2014-06-04 20:29 (#732) - ObjectListView/Implementation/OLVListItem.cs
  - Added OLVListItem.Enabled flag

2014-06-04 20:28 (#731) - ObjectListView/DragDrop/OLVDataObject.cs
  - When the listview is completely empty, don't try to set CSV text in the clipboard.

2014-06-04 20:27 (#730) - ObjectListView/CellEditing/CellEditKeyEngine.cs
  - When a row is disabled, skip over it when looking for another cell to edit

2014-06-04 20:26 (#729) - ListViewPrinter/Properties/AssemblyInfo.cs
  - Update copyright

2014-06-04 20:26 (#728) - docs/images/blog8-funnyformatting.png, docs/blog8.rst, docs/images/blog8-greytext-colourimages.png, docs/index.rst, docs/blog.rst, docs/images/blog8-allgrey.png, docs/recipes.rst, docs/.static/objectlistview32.png, docs/.static/blog8-icon.png, docs/.templates/layout.html
  - Added documentation on disable rows

2014-06-04 20:23 (#727) - SparkleLibrary/Sprites/ShapeSprite.cs, SparkleLibrary/Locators/Locators.cs, SparkleLibrary/Animation/Animation.cs, SparkleLibrary/Sprites/Sprite.cs
  - Update copyright

2014-04-26 00:39 (#726) - ObjectListView/VirtualObjectListView.cs, Tests/Tests2012.csproj, ObjectListView/ObjectListView.cs
  - Fixed bug where virtual lists containing a single row didn't update hyperlinks on mouse over
  - Added sanity check before BuildGroups()

2014-03-22 23:37 (#725) - ObjectListView/VirtualObjectListView.cs, ObjectListView/TreeListView.cs, ObjectListView/ObjectListView.cs
  - Fixed some subtle bugs resulting from misuse of TryGetValue()

2014-03-09 22:10 (#724) - ObjectListView/ObjectListView2012.csproj, ObjectListView/ObjectListView.cs, ObjectListView/CellEditing/CellEditKeyEngine.cs
  - Added CollapsedGroups property
  - Several minor Resharper complaints quiesced.

2014-03-09 22:08 (#723) - ObjectListView/TreeListView.cs, Tests/TestTreeView.cs, Tests/Tests2012.csproj
  - Fixed bug where removing a branches only child and then calling RefreshObject() could throw an exception.



v2.7 - 28 February 2014
-----------------------

2014-02-23 17:52 (#721) - ObjectListView/Properties/AssemblyInfo.cs
  - Updated version to v2.7.0

2014-02-23 17:52 (#720) - ObjectListView/TreeListView.cs
  - Added Reveal() method to show a deeply nested models.

2014-02-23 17:51 (#719) - ObjectListView/Implementation/NativeMethods.cs, ObjectListView/ObjectListView.cs
  - Fixed a bug with ShowHeaderInAllViews (another one!) where setting it to false caused the list to lose its other extended styles, leading to nasty flickering and worse.

2014-02-23 16:59 (#718) - docs/blog.rst, Demo/Resources/coffee.jpg, docs/recipes.rst, docs/.templates/layout.html, docs/download.rst, Demo/MainForm.resx, docs/changelog.rst, docs/features.rst, docs/whatsnew.rst, docs/olv-sandcastle.shfbproj, docs/blog7.rst, docs/index.rst, docs/conf.py, docs/.static/blog7-icon.png, Demo/MainForm.cs, docs/images/hierarchical-checkboxes-1.png, Demo/MainForm.Designer.cs
  - Update docs and demo for v2.7

2014-02-23 16:51 (#717) - Tests/TestTreeView.cs, Tests/packages.config, Tests/TestBasics.cs
  - More tests :)

2014-02-12 20:39 (#716) - ObjectListView/TreeListView.cs, ObjectListView/ObjectListView.cs
  - AddObjects() now adds objects to the end of the list even if filtering is turned on
  - ShowHeaderInAllViews now works on virtual lists

2014-02-07 06:10 (#715) - ObjectListView/Implementation/Events.cs, ObjectListView/ObjectListView.cs
  - Added CellEditEventArgs.AutoDispose to allow cell editors to be disposed after use. Defaults to true. This allows heavy controls to be cached for reuse.
  - Bracketed column resizing with BeginUpdate/EndUpdate to smooth redraws (thanks to Davide)
  - Check for null when search-by-typing to catch rare/bizarre condition where GetNthItemInDisplayOrder() returns null

2014-02-07 05:19 (#714) - ObjectListView/ObjectListView.cs
  - Fix bug on virtual lists where the filter was not correctly reapplied after columns were added or removed.

2014-02-07 05:19 (#713) - Tests/TestTreeView.cs, Tests/Person.cs
  - Added test for model filter and column change interactions

2014-02-05 13:23 (#712) - Tests/TestSorting.cs, Tests/TestTreeView.cs, Tests/Person.cs, Tests/TestExport.cs
  - Updated unit tests

2014-02-05 13:23 (#711) - ObjectListView/TreeListView.cs
  - Fix bug where refreshing a non-root item would collapse all expanded children of that item
  - ClearObjects() now actually, you know, clears objects :)
  - Corrected bug where Expanded event was being raised twice.
  - RebuildChildren() no longer checks if CanExpand is true before rebuilding.
  - Added public getter for TreeListView.TreeModel

2014-02-05 13:19 (#710) - Demo/ShellUtilities.cs
  - Resize shell images to match the current image size on the control

2014-02-05 13:18 (#709) - ListViewPrinterDemo/ListViewPrinterDemo2012.csproj, ObjectListView/ObjectListView2012.csproj, Demo/ObjectListViewDemo2012.csproj, Demo/ObjectListViewDemo2005.csproj, Tests/Tests2012.csproj, Demo/ObjectListViewDemo2008.csproj, Tests/Tests2005.csproj, ObjectListView2012.sln, ListViewPrinter/ListViewPrinter2012.csproj, Tests/Tests2008.csproj
  - Added VS 2012 solution

2014-02-05 13:17 (#708) - ObjectListView/OLVColumn.cs, ObjectListView/Implementation/Events.cs, ObjectListView/ObjectListView.cs
  - Added static property ObjectListView.GroupTitleDefault to allow the default group title to be localised

2014-01-28 06:48 (#707) - ObjectListView/TreeListView.cs
  - Corrected an off-by-1 error in hit detection, which meant that clicking in the last 16 pixels of an items label was being ignored.

2014-01-28 06:47 (#706) - ObjectListView/OLVColumn.cs
  - Remove experimental CheckBoxSettings (which somehow escaped into the wild)

2014-01-28 06:46 (#705) - ObjectListView/ObjectListView.cs
  - Remove experimental CheckBoxSettings (which somehow escaped into the wild)

2013-12-04 21:54 (#704) - ObjectListView/VirtualObjectListView.cs, ObjectListView/TreeListView.cs, ObjectListView/ObjectListView.cs
  - Moved event triggers into Collapse() and Expand() so that the events are always triggered.
  - CheckedObjects now includes objects that are in a branch that is currently collapsed
  - CollapseAll() and ExpandAll() now trigger cancellable events
  - Added TreeFactory to allow the underlying Tree to be replaced by another implementation.
  - HierarchicalCheckboxes now seems to work in all cases

2013-12-04 21:50 (#703) - Tests/TestNotifications.cs, Tests/TestColumn.cs, Tests/TestTreeView.cs, Tests/Person.cs, Tests/TestCheckBoxes.cs, Tests/MainForm.cs, Tests/TestBasics.cs
  - Added lots more unit tests

2013-12-04 21:49 (#702) - Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Minor changes to test HierarchicalCheckboxes

2013-11-24 13:31 (#701) - Tests/TestDateClusteringStrategy.cs, Tests/TestFlagClusteringStrategy.cs, Tests/TestTypedListView.cs
  - Adding missing unit test files

2013-09-24 00:18 (#700) - ObjectListView/Properties/AssemblyInfo.cs
  - Update version number to 2.6.1

2013-09-24 00:17 (#699) - ObjectListView/Implementation/VirtualListDataSource.cs
  - Added support for new UpdateObject() method

2013-09-24 00:17 (#698) - ObjectListView/ObjectListView.cs
  - Fixed bug in RefreshObjects() when model objects overrode the Equals()/GetHashCode() methods.
  - Made sure get state checker were used when they should have been

2013-09-24 00:16 (#697) - ObjectListView/FastObjectListView.cs, ObjectListView/VirtualObjectListView.cs, ObjectListView/TreeListView.cs
  - Added support for new UpdateObject() method
  - Fixed bugs in existing RefreshObjects()

2013-09-24 00:15 (#696) - Tests/TestNotifications.cs, Tests/TestFilters.cs, Tests/TestTreeView.cs, Tests/Tests2010.csproj, Tests/Person.cs, Tests/TestCheckBoxes.cs, Tests/TestBasics.cs, Tests/TestExport.cs
  - Added more tests, especially around RefreshObject()

2013-08-18 16:49 (#695) - ObjectListView/Properties/AssemblyInfo.cs, ObjectListView/Implementation/OlvListViewHitTestInfo.cs, ObjectListView/Filtering/FlagClusteringStrategy.cs, ObjectListView/OLVColumn.cs, ObjectListView/ObjectListView.DesignTime.cs, ObjectListView/ObjectListView.cs, ObjectListView/DragDrop/OLVDataObject.cs
  - Clicking on a non-groupable column header when showing groups will now sort the group contents by that column.
  - Added more docs

2013-08-18 16:48 (#694) - ObjectListView/Rendering/Renderers.cs
  - Fixed bug where Images were not vertically aligned

2013-08-18 16:47 (#693) - ObjectListView/Utilities/ColumnSelectionForm.cs
  - Fixed obscure bug in column re-ordered. Thanks to Edwin Chen.



v2.6 - 01 November 2012
-----------------------

2012-10-30 20:15 (#691) - ObjectListView/Properties/AssemblyInfo.cs
  - Update version number

2012-10-30 20:15 (#690) - ObjectListView/Utilities/TypedObjectListView.cs
  - Handle rare case where a null model object was passed into aspect getters.

2012-10-30 20:14 (#689) - ObjectListView/Rendering/Renderers.cs
  - Hit detection will no longer report check box hits on columns without checkboxes.

2012-10-30 20:13 (#688) - Tests/TestBasics.cs
  - Added tests for TypedObjectListView

2012-10-30 20:13 (#687) - ObjectListView/TreeListView.cs
  - Circumvent annoying bug in ListView control where changing selection would leave artefacts on the control.

2012-10-16 09:28 (#686) - docs/features.rst, Tests/TestGenerator.cs, docs/whatsnew.rst, docs/recipes.rst, Demo/MainForm.cs, ObjectListView/ObjectListView.cs, docs/.templates/layout.html, Demo/MainForm.Designer.cs, ObjectListView/Utilities/Generator.cs, Demo/MainForm.resx, docs/changelog.rst
  - Small changes preparing for v2.6 release

2012-10-13 17:11 (#685) - ObjectListView/TreeListView.cs
  - Don't trigger selection changed events during expands
  - Check that branches can still expand during Rebuild() and ExpandAll()

2012-10-13 17:09 (#684) - ObjectListView/ObjectListView2010.csproj
  - Undefine DEBUG symbol in release build

2012-10-13 17:08 (#683) - ObjectListView/ObjectListView.DesignTime.cs
  - Fall back to more specific type name for the ListViewDesigner if the first GetType() fails.

2012-10-13 17:07 (#682) - ObjectListView/ObjectListView.cs
  - Added ObjectListView.EditModel() -- a convenience method to start an edit operation on a model
  - Don't trigger selection changed events during sorting/grouping or add/removing columns
  - SmallImageSize is now calculated correctly
  - TopItemIndex now uses a WinAPI message rather than messing with the fragile ListView.TopItem property
  - Added AutoSizeColumns() which will resize columns that have a width of 0 or -1 to the width of their contents or header respectively
  - GroupingParameters.ItemComparer is now honoured
  - Unlock grouping menu command now correctly resets AlwaysGroupBySortOrder
  - Internally use PrimarySortColumn and PrimarySortOrder instead of LastSortColumn and LastSortOrder

2012-10-13 16:59 (#681) - ObjectListView/Rendering/Renderers.cs
  - Only use Timer when redrawing animated GIFs. Release Timer when animation is paused.

2012-10-13 16:57 (#680) - ObjectListView/Filtering/TextMatchFilter.cs
  - Allow filtering to consider additional columns

2012-10-13 16:56 (#679) - Demo/ObjectListViewDemo2005.csproj, Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Show off treeview data binding

2012-08-22 21:53 (#678) - Tests/TestGenerator.cs, Tests/TestSelection.cs, Tests/TestColumn.cs, Tests/TestBasics.cs
  - Added tests for EffectiveRowHeight, IgnoreMissingAspects
  - Added tests for not raising selection events whilst rebuilding the list
  - Added tests for [OLVChildren] and [OLVIgnore]

2012-08-22 21:51 (#677) - ObjectListView/Utilities/TypedObjectListView.cs
  - Honour IgnoreMissingAspects when generating methods for aspect getters

2012-08-22 21:50 (#676) - ObjectListView/Utilities/Generator.cs
  - Generator now uses [OLVChildren] attribute to select a property to auto generate CanExpandGetter and ChildrenGetters
  - Generator now honours [OLVIgnore] attribute.
  - Made clear the Generator only works on properties, not fields or parameter-less methods
  - If generator sets ImageAspectGetter on a non-primary column, it automatically enabled images on subitems.
  - Slightly better column title generation: "MyPropertyName" => "My Property Name"

2012-08-22 21:45 (#675) - ObjectListView/Rendering/TreeRenderer.cs
  - Tree renderer now correctly vertically aligns the tree structure
  - It also takes cell padding into account

2012-08-22 21:44 (#674) - ObjectListView/Rendering/Renderers.cs
  - Made all renderers correctly honour padding and cell alignment
  - HighlightTextRenderer now correctly vertically positions the highlighing
  - Made rendering work without a Column being set

2012-08-22 21:42 (#673) - ObjectListView/Rendering/Adornments.cs
  - Correctly dispose of brush and pen resources
  - Made lots of methods virtual

2012-08-22 21:41 (#672) - ObjectListView/Implementation/OLVListItem.cs
  - Trivial code refactor

2012-08-22 21:40 (#671) - ObjectListView/Implementation/NativeMethods.cs
  - Added LVM_GETTOPINDEX message

2012-08-22 21:40 (#670) - ObjectListView/Implementation/Munger.cs
  - Automatically set IgnoreMissingAspects to true on DEBUG builds only
  - Added Munger.GetValueEx() which will actually throw an exception

2012-08-22 21:38 (#669) - ObjectListView/Implementation/DataSourceAdapter.cs
  - Unify common column creation functionality with Generator when possible

2012-08-22 21:38 (#668) - ObjectListView/Implementation/Attributes.cs
  - Added [OLVChildren] and [OLVIgnore]
  - OLV attributes can now only be set on properties

2012-08-08 22:41 (#667) - docs/features.rst, docs/whatsnew.rst, docs/index.rst, docs/conf.py, docs/recipes.rst, docs/.templates/layout.html, docs/download.rst, docs/changelog.rst
  - Updated docs in preparation for v2.6 release

2012-08-08 22:40 (#666) - Tests/TestGenerator.cs, Tests/Tests2010.csproj, Tests/Tests2005.csproj, Tests/TestExport.cs, Tests/Tests2008.csproj
  - Added tests for OLVExporter
  - Added tests for Generator without [OLVColumn] attributes

2012-08-08 22:39 (#665) - ObjectListView/Utilities/OLVExporter.cs, ObjectListView/ObjectListView2010.csproj, ObjectListView/ObjectListView2005.csproj, ObjectListView/ObjectListView2008.csproj, ObjectListView/ObjectListView.cs, ObjectListView/DragDrop/OLVDataObject.cs
  - Added OLVExporter.cs
  - Clipboard now includes CSV format

2012-08-06 10:37 (#664) - ObjectListView/ObjectListView.cs
  - Added CellPadding and CellVerticalAlignment properties
  - Don't start a cell edit operation when the user clicks on the background of a checkbox cell.
  - Honor values from the BeforeSorting event when calling a CustomSorter
  - Added ObjectListView.ShowCellPaddingBounds to help with figuring out cell padding problems.
  - Ensure that any cell edit operations finishes when the window moves

2012-08-06 10:33 (#663) - ObjectListView/SubControls/GlassPanelForm.cs
  - Make sure we Unbind when Disposing of the GlassPanelForm

2012-08-06 10:32 (#662) - ObjectListView/OLVColumn.cs
  - Added CellPadding and CellVerticalAlignment properties

2012-08-06 10:32 (#661) - ObjectListView/Rendering/TreeRenderer.cs
  - Added preferedSize parameter to IRenderer.GetEditRectangle().

2012-08-06 10:31 (#660) - ObjectListView/Rendering/Renderers.cs
  - [Breaking change] Added preferedSize parameter to IRenderer.GetEditRectangle().
  - Added CellPadding to various places. Replaced DescribedTaskRenderer.CellPadding.
  - Added CellVerticalAlignment to various places allow cell contents to be vertically aligned (rather than always being centered)

2012-08-06 10:27 (#659) - ObjectListView/Implementation/OLVListItem.cs, ObjectListView/Implementation/OLVListSubItem.cs
  - Added CellPadding and CellVerticalAlignment properties

2012-08-06 10:27 (#658) - ObjectListView/Implementation/NullableDictionary.cs
  - Fixed bug where Values did not return the value associated with the null key.

2012-08-06 10:25 (#656) - ObjectListView/CellEditing/CellEditors.cs
  - Make most editors public so they can be reused/subclassed. UintUpDown editor cannot be made public since uint type is not CLR compliant.

2012-07-21 17:37 (#655) - ObjectListView/ObjectListView.cs
  - Fixed bug with cell editing where the cell editing didn't finish until the first idle event. This meant that if you clicked and held on the scroll thumb to finish a cell edit, the editor wouldn't be removed until the mouse was released.
  - Fixed bug with SingleClick cell edit mode where the cell editing would not begin until the mouse moved after the click.
  - Fixed bug where removing a column from a LargeIcon or SmallIcon view would crash the control.
  - Added Reset() method, which definitively removes all rows *and* columns from an ObjectListView.
  - Added FilteredObjects property which returns the collection of objects that survives any installed filters.

2012-07-21 17:33 (#654) - ObjectListView/TreeListView.cs
  - Try to preserve vertical scroll position when rebuilding the list

2012-07-21 17:32 (#653) - ObjectListView/VirtualObjectListView.cs
  - Corrected several bugs related to groups on virtual lists.
  - Added EnsureNthGroupVisible() since EnsureGroupVisible() can't work on virtual lists.

2012-07-21 17:31 (#652) - ObjectListView/FastObjectListView.cs
  - Correct search-by-typing when grouped

2012-07-21 17:30 (#651) - ObjectListView/DataListView.cs
  - Updated docs for changing DataSources on DataListView

2012-07-21 17:27 (#650) - ObjectListView/Utilities/Generator.cs
  - Allow columns to be generated even if they are not marked with [OLVColumn]
  - Converted class from static to instance to allow it to be subclassed. Also, added IGenerator to allow it to be completely reimplemented.

2012-07-21 17:26 (#649) - ObjectListView/Properties/AssemblyInfo.cs
  - Updated to 2.6b version

2012-07-21 17:24 (#648) - ObjectListView/Implementation/TreeDataSourceAdapter.cs
  - Override ChangePosition() so that it reveals the item within its parent

2012-07-21 17:24 (#647) - ObjectListView/Implementation/DataSourceAdapter.cs
  - Separated ChangePosition() method so it can be overridden in derived classes

2012-07-21 17:23 (#646) - ObjectListView/Implementation/Attributes.cs
  - There are several property where we actually want nullable value (bool?, int?), but it seems attribute properties can't be nullable types. So we explicitly track if those properties have been set.

2012-07-21 17:21 (#645) - ObjectListView/CellEditing/CellEditors.cs
  - Made internal editors so they can be reused

2012-06-11 14:31 (#643) - Demo/ObjectListViewDemo2010.csproj, Demo/MainForm.cs, Demo/FamilyTree.xml, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Added Data-bound tree list view

2012-06-11 14:30 (#642) - Tests/TestSorting.cs, Tests/TestNotifications.cs, Tests/TestFilters.cs, Tests/Tests2010.csproj, Tests/Person.cs, Tests/TestBasics.cs, Tests/Tests2005.csproj, Tests/Tests2008.csproj
  - Added new clustering tests
  - Added notification tests

2012-06-11 14:28 (#641) - ObjectListView/ObjectListView2010.csproj, ObjectListView/ObjectListView2005.csproj, ObjectListView/ObjectListView2008.csproj
  - Added new files
  - Remove unused resource

2012-06-11 14:27 (#640) - ObjectListView/VirtualObjectListView.cs
  - Update subscriptions when model objects change

2012-06-11 14:27 (#639) - ObjectListView/TreeListView.cs
  - When refreshing children, only fetch children if the branch is already expanded and can be expanded

2012-06-11 14:24 (#638) - ObjectListView/OLVColumn.cs
  - ValueBasedFilter property now defers filter creation to the clustering strategy

2012-06-11 14:23 (#637) - ObjectListView/ObjectListView.cs
  - [Big] Added UseNotifyPropertyChanged to allow OLV to listen for INotifyPropertyChanged events on models.
  - Added static property ObjectListView.IgnoreMissingAspects. If this is set to true, all ObjectListViews will silently ignore missing aspect errors. Read the remarks to see why this would be useful.
  - Setting UseFilterIndicator to true now sets HeaderUsesTheme to false. Also, changed default value of UseFilterIndicator to false. Previously, HeaderUsesTheme and UseFilterIndicator defaulted to true, which was pointless since when the HeaderUsesTheme is true, UseFilterIndicator does nothing.
  - Inserting objects on a filtered list now triggers ItemsChanged event as it should have

2012-06-11 14:20 (#636) - ObjectListView/FastObjectListView.cs
  - Added more efficient implementation of FilteredObjectList to FastObjectListView

2012-06-11 14:18 (#635) - ObjectListView/DataTreeListView.cs, ObjectListView/DataListView.cs
  - Added DataTreeListView, a data-bound tree view
  - Added AutoGenerateColumns to DataListView to allow control of whether the columns will be generated from the data source

2012-06-11 14:14 (#634) - ObjectListView/SubControls/GlassPanelForm.cs
  - Explicitly remember the widget hierarchy when the GlassPanelForm is created so that when it is destroyed, we can unsubscribe from the correct widgets -- even if the widget hierarchy changes.

2012-06-11 14:12 (#633) - ObjectListView/Implementation/DataSourceAdapter.cs, ObjectListView/Implementation/TreeDataSourceAdapter.cs, ObjectListView/Implementation/Munger.cs
  - Added TreeDataSourceAdapter, used for DataTreeListView
  - Added finalizer to DataSourceAdapter

2012-06-11 13:55 (#632) - ObjectListView/DragDrop/DropSink.cs
  - Added UseDefaultCursors which allows the user to choose if default cursors will be used during drag and drop operations

2012-06-11 13:55 (#631) - ObjectListView/Filtering/FlagClusteringStrategy.cs, ObjectListView/Filtering/ClusteringStrategy.cs, ObjectListView/Filtering/IClusteringStrategy.cs, ObjectListView/Filtering/Filters.cs, ObjectListView/Filtering/FilterMenuBuilder.cs, ObjectListView/Filtering/DateTimeClusteringStrategy.cs
  - Allow the same model object to be in multiple clusters. Useful for xor'ed flag fields, and multi-value strings (e.g. hobbies that are stored as comma separated values).
  - Added CreateFilter to IClusteringStrategy interface
  - Added FlagClusteringStrategy, which groups model objects based on an xor-ed collection of bit flags
  - Added FlagBitSetFilter, which filters model objects based on an xor-ed collection of bit flags

2012-05-07 16:16 (#630) - ObjectListView/ObjectListView.cs
  - Fix bug where collapsing the first group would cause decorations to stop being drawn (SR #3502608)

2012-05-07 16:16 (#629) - ObjectListView/ObjectListView.DesignTime.cs
  - Removed some non-2.0 language usage

2012-05-07 16:15 (#628) - ObjectListView/VirtualObjectListView.cs
  - VirtualObjectListView.CheckBoxes is now correctly marked with a default value of false.

2012-05-07 16:15 (#627) - ObjectListView/ObjectListView2008.csproj
  - Turn off XML docs generation

2012-05-07 16:14 (#626) - ObjectListView/Rendering/Overlays.cs
  - Don't draw a text overlay if it has no text

2012-05-07 16:14 (#625) - docs/whatsnew.rst, docs/blog6.rst, docs/index.rst, docs/blog.rst, docs/.templates/layout.html, docs/changelog.rst
  - Ready for 2.5.1 release

2012-05-04 23:38 (#624) - ObjectListView/ObjectListView.cs
  - Added ObjectListView.IgnoreMissingAspects static property

2012-05-04 23:37 (#623) - ObjectListView/Properties/AssemblyInfo.cs, ObjectListView/Utilities/TypedObjectListView.cs, ObjectListView/Filtering/TextMatchFilter.cs, ObjectListView/Implementation/NullableDictionary.cs, ObjectListView/Implementation/VirtualListDataSource.cs, ObjectListView/Filtering/ClusteringStrategy.cs, ObjectListView/Implementation/Attributes.cs, ObjectListView/Filtering/IClusteringStrategy.cs, ObjectListView/Implementation/Comparers.cs, ObjectListView/Filtering/ICluster.cs, ObjectListView/Implementation/GroupingParameters.cs, ObjectListView/CellEditing/EditorRegistry.cs, ObjectListView/Implementation/NativeMethods.cs, docs/recipes.rst, ObjectListView/CellEditing/CellEditors.cs, ObjectListView/CellEditing/CellEditKeyEngine.cs, docs/olv-sandcastle.shfbproj, ObjectListView/Implementation/OLVListItem.cs, ObjectListView/Rendering/Overlays.cs, ObjectListView/Implementation/Delegates.cs, ObjectListView/DataListView.cs, ObjectListView/OLVColumn.cs, docs/.static/flicker-gone.swf, ObjectListView/Rendering/Renderers.cs, ObjectListView/Implementation/OLVListSubItem.cs, ObjectListView/SubControls/GlassPanelForm.cs, ObjectListView/DragDrop/DropSink.cs, ObjectListView/Rendering/Decorations.cs, ObjectListView/DragDrop/OLVDataObject.cs, ObjectListView/Implementation/VirtualGroups.cs, ObjectListView/Implementation/OlvListViewHitTestInfo.cs, ObjectListView/TreeListView.cs, ObjectListView/Implementation/DataSourceAdapter.cs, ObjectListView/Rendering/Styles.cs, ObjectListView/Filtering/Filters.cs, docs/.static/flicker.swf, ObjectListView/Filtering/ClustersFromGroupsStrategy.cs, ObjectListView/Implementation/Munger.cs, ObjectListView/Utilities/Generator.cs, ObjectListView/Filtering/DateTimeClusteringStrategy.cs, ObjectListView/FastObjectListView.cs, ObjectListView/VirtualObjectListView.cs, ObjectListView/SubControls/ToolStripCheckedListBox.cs, ObjectListView/ObjectListView2010.csproj, docs/blog6.rst, ObjectListView/FastDataListView.cs, ObjectListView/Rendering/Adornments.cs, ObjectListView/Implementation/Enums.cs, ObjectListView/Filtering/Cluster.cs, ObjectListView/SubControls/ToolTipControl.cs, docs/.static/blog6-icon.png, ObjectListView/SubControls/HeaderControl.cs, ObjectListView/Filtering/FilterMenuBuilder.cs, ObjectListView/DragDrop/DragSource.cs
  - Avoid bug/feature in ListView.VirtalListSize setter that causes flickering when the size of the list changes.

2012-04-30 23:48 (#622) - Tests/TestFilters.cs, Tests/TestTreeView.cs, Tests/TestCheckBoxes.cs
  - Exercised a few more code paths through TreeListView

2012-04-30 23:48 (#621) - ObjectListView/TreeListView.cs
  - Fixed bug where CheckedObjects would return model objects that had been filtered out.
  - Allow any column to render the tree, not just column 0 (still not sure about this one)
  - Fixed some minor issues

2012-04-30 23:47 (#620) - ObjectListView/VirtualObjectListView.cs, ObjectListView/ObjectListView.cs
  - Updated some doc comments

2012-04-30 23:47 (#619) - docs/filtering.rst, docs/whatsnew.rst, docs/images/setbkimage2.png, docs/blog5.rst, docs/index.rst, docs/blog.rst, docs/images/setbkimage.png, docs/conf.py, docs/recipes.rst, docs/changelog.rst
  - Major update to blog about listview groups
  - Add new docs about native background images
  - Updated ready for 2.5.1 release

2012-04-26 23:22 (#618) - Demo/MainForm.cs
  - Remove unnecessary Invalidate()

2012-04-26 23:21 (#617) - ObjectListView/TreeListView.cs, ObjectListView/Implementation/Events.cs, ObjectListView/ObjectListView.DesignTime.cs, ObjectListView/ObjectListView.cs
  - Correctly categorize properties and events for the Designer
  - Hide group related properties and events on TreeListViews in designer.

2012-04-25 20:21 (#616) - docs/blog4.rst, docs/blog5.rst, docs/images/ClassDiagram.png, docs/index.rst, docs/dragdrop.rst, docs/blog.rst, docs/images/ClassDiagram-VirtualList.png, docs/conf.py, docs/.static/blog5-icon.png, docs/ClassDiagram.dia, docs/faq.rst, docs/.templates/layout.html
  - Added new blog about improving ListViewGroups

2012-04-25 20:19 (#615) - Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Show what is under the mouse in the status bar

2012-04-25 20:18 (#614) - ObjectListView/Implementation/OlvListViewHitTestInfo.cs, ObjectListView/Implementation/OLVListItem.cs, ObjectListView/Implementation/NativeMethods.cs, ObjectListView/Implementation/Events.cs, ObjectListView/DragDrop/DropSink.cs, ObjectListView/Implementation/Groups.cs
  - Added group state change and group expansion events
  - Improved hit testing to include groups

2012-04-25 20:16 (#613) - ObjectListView/ObjectListView.cs
  - Trigger GroupExpandingCollapsing event to allow the expand/collapse to be cancelled
  - Fixed SetGroupSpacing() so it corrects updates the space between all groups.
  - ResizeLastGroup() now does nothing since it was broken and I can't remember what it was even supposed to do :)
  - Upgraded hit testing to include hits on groups.
  - HotItemChanged is now correctly recalculated on each mouse move. Includes "hot" group information.

2012-04-25 20:14 (#612) - ObjectListView/VirtualObjectListView.cs
  - Fixed bug that occurred when adding/removing item while the view was grouped.

2012-04-25 20:13 (#611) - ObjectListView/ObjectListView2010.csproj, ObjectListView/FullClassDiagram.cd
  - Added class diagram

2012-04-14 16:26 (#610) - , ObjectListView/Filtering/FilterMenuBuilder.cs
  - Fixed rare bug with clustering an empty list (SF #3445118)

2012-04-14 16:06 (#609) - Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Listen for GroupStateChanged events

2012-04-14 16:05 (#608) - ObjectListView/CellEditing/CellEditKeyEngine.cs
  - Fixed bug where, on a OLV with only a single editable column, tabbing to change rows would edit the cell above rather than the cell below the cell being edited.

2012-04-14 15:41 (#607) - ObjectListView/Implementation/NativeMethods.cs, ObjectListView/Implementation/Events.cs, ObjectListView/ObjectListView.cs, ObjectListView/Implementation/Groups.cs
  - Added GroupStateChanged event. Useful for knowing when a group is collapsed/expanded.

2012-04-12 14:15 (#606) - Tests/SetupTestSuite.cs, Tests/MainForm.Designer.cs, Tests/TestCheckBoxes.cs, Tests/MainForm.resx
  - Added tests for PersistentCheckBoxes

2012-04-12 14:14 (#605) - ObjectListView/VirtualObjectListView.cs, ObjectListView/Filtering/Filters.cs, ObjectListView/Resources/coffee.jpg, ObjectListView/Rendering/Renderers.cs, ObjectListView/SubControls/HeaderControl.cs, ObjectListView/ObjectListView.cs
  - Added PersistentCheckBoxes property

2012-04-12 14:14 (#604) - ListViewPrinterDemo/Properties/Resources.Designer.cs, ListViewPrinterDemo/Properties/Resources.resx
  - Removed unused resource compass16

2012-04-12 14:13 (#603) - docs/recipes.rst
  - Added docs about PersistentCheckBoxes

2012-04-12 14:12 (#602) - Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Changed demo to use additionalFilter rather than ModelFilter

2012-04-07 15:40 (#601) - ObjectListView/TreeListView.cs, ObjectListView/ObjectListView.cs
  - Tweaked some code. No functional change

2012-04-07 15:38 (#600) - ObjectListView/Implementation/Munger.cs
  - Reverted some code to .NET 2.0 standard

2012-04-07 15:20 (#599) - ObjectListView/Rendering/Renderers.cs
  - Check that we don't try to draw an image beyong the end of the image list

2012-04-07 15:19 (#598) - ObjectListView/Implementation/Munger.cs
  - Fix bug that appears when a class has an Item() method with zero parameters

2012-04-07 15:17 (#597) - Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Exercise a few more code paths in the demo

2012-04-07 15:14 (#596) - ObjectListView/ObjectListView.cs
  - Fixed bug where clicking on a separator in the column select menu causes a crash

2011-06-26 13:42 (#595) - ObjectListView/Filtering/TextMatchFilter.cs
  - Handle searching for empty strings

2011-06-26 13:42 (#594) - ObjectListView/OLVColumn.cs
  - Small format changes

2011-06-26 13:41 (#593) - ObjectListView/ObjectListView.cs
  - Added CanUseApplicationIdle property to cover cases where Application.Idle events are not triggered. For example, when used within VS (and probably Office) extensions Application.Idle is never triggered. Set CanUseApplicationIdle to false to handle these cases.
  - Handle cases where a second tool tip is installed onto the ObjectListView.
  - Correctly recolour rows after an Insert or Move
  - Removed m.LParam cast which could cause overflow issues on Win7/64 bit.

2011-06-26 13:39 (#592) - ObjectListView/ObjectListView.DesignTime.cs
  - Vastly improved ObjectListViewDesigner, based off information in "'Inheriting' from an Internal WinForms Designer" on CodeProject.



v2.5 - 06 June 2011
-------------------

2011-06-06 23:25 (#590) - docs/blog.rst, docs/.templates/layout.html, docs/download.rst, docs/changelog.rst
  - Finalize v2.5.0 docs

2011-06-06 23:25 (#589) - Demo/MainForm.cs
  - Remove Debug statements

2011-06-06 23:24 (#588) - ObjectListView/FastObjectListView.cs, ObjectListView/Filtering/Filters.cs, ObjectListView/ObjectListView.cs
  - Correctly take ownership of objects before modifying objects collection

2011-06-04 23:30 (#585) - ObjectListView/ObjectListView.cs
  - Fixed bug where group image list was being lost

2011-06-04 23:03 (#584) - docs/Help/ObjectListView-Documentation.chm
  - v2.5.0

2011-06-04 22:28 (#581) - ObjectListView/VirtualObjectListView.cs
  - Made setting CheckedObjects more efficient on large collections

2011-06-04 22:27 (#580) - ObjectListView/ObjectListView.cs
  - SelectObject() and SelectObjects() no longer deselect all other rows. Set the SelectedObject or SelectedObjects property to do that.
  - Added CheckedObjectsEnumerable
  - Made setting CheckedObjects more efficient on large collections
  - Deprecated GetSelectedObject() and GetSelectedObjects()

2011-06-04 22:26 (#579) - ObjectListView/ObjectListView2010.csproj, ObjectListView/ObjectListView2005.csproj, ObjectListView/ObjectListView2008.csproj
  - Added columnselectionform.resx to projects

2011-06-04 22:26 (#578) - ObjectListView/Utilities/TypedObjectListView.cs
  - Change to using SelectedObject property rather than GetSelectedObject() method

2011-06-04 22:25 (#577) - ObjectListView/Utilities/ColumnSelectionForm.cs
  - Correctly enable controls when the form is first loaded

2011-06-04 22:24 (#576) - ObjectListView/Implementation/OLVListItem.cs
  - Added Checked property

2011-06-04 22:24 (#575) - docs/whatsnew.rst, docs/images/column-selection-modaldialog.png, docs/index.rst, docs/recipes.rst, docs/images/column-selection-submenu.png, docs/images/column-selection-inline.png, docs/faq.rst
  - Added new section about column selection
  - Improved section about checkboxes
  - Added more FAQs

2011-06-04 22:23 (#574) - Demo/MainForm.cs
  - Change to using SelectedObject property rather than GetSelectedObject() method

2011-05-31 23:04 (#573) - ObjectListView/Filtering/TextMatchFilter.cs, ObjectListView/Filtering/Filters.cs
  - Moved TextMatchFilter to its own file

2011-05-31 23:04 (#572) - docs/features.rst, docs/whatsnew.rst, docs/olv-sandcastle.shfbproj, docs/index.rst, docs/images/excel-filtering.png, docs/conf.py, docs/recipes.rst, docs/.templates/layout.html, docs/changelog.rst
  - v2.5 docs almost done

2011-05-31 23:03 (#571) - ObjectListView/VirtualObjectListView.cs
  - Reorganized code

2011-05-31 23:02 (#570) - ObjectListView/OLVColumn.cs
  - Added Sortable, Hideable, Groupable, Searchable, ShowTextInHeader properties

2011-05-31 23:02 (#569) - ObjectListView/ObjectListView.cs
  - Honour OLVColumn.Sortable and Groupable settings
  - Added ObjectListView.EnumerableToArray
  - Improved docs

2011-05-31 22:59 (#568) - ObjectListView/Utilities/ColumnSelectionForm.cs
  - Honour OLVColumn.Hideable setting

2011-05-31 22:59 (#567) - ObjectListView/FastObjectListView.cs
  - Use ObjectListView.EnumerableToArray
  - Improved docs

2011-05-31 22:58 (#566) - ObjectListView/ObjectListView2010.csproj, ObjectListView/ObjectListView2005.csproj, ObjectListView/ObjectListView2008.csproj
  - Added TextMatchFilter.cs to projects

2011-05-31 22:57 (#565) - ObjectListView/SubControls/HeaderControl.cs
  - Fixed bug that prevented columns from being resized in IDE Designer by dragging the column divider
  - Honour OLVColumn.ShowTextInHeader setting

2011-05-31 22:55 (#564) - ObjectListView/Rendering/Renderers.cs
  - Correctly draw subitem checkboxes when printing
  - Tidied up text highlighting a little

2011-05-31 22:54 (#563) - ObjectListView/Implementation/DataSourceAdapter.cs
  - Optimized adaptor
  - Improved docs

2011-05-31 22:52 (#562) - ObjectListView/Implementation/NativeMethods.cs
  - Improved ability to set the native background image

2011-05-31 22:51 (#561) - ObjectListView/Implementation/Munger.cs
  - Fixed situation where accessing a data value through an indexer when the target had both a integer and a string indexer didn't work reliably.

2011-05-31 22:50 (#560) - Demo/MainForm.cs
  - Use new text match filter factory methods

2011-05-31 22:50 (#559) - Tests/TestSorting.cs
  - Fast OLVs cant Unsort, so don't test it

2011-05-31 22:49 (#558) - Tests/TestFilters.cs
  - Improved text match tests

2011-05-18 22:56 (#556) - ObjectListView/OLVColumn.cs
  - Added MakeEqualGroupies()

2011-05-18 22:55 (#555) - ObjectListView/ObjectListView.cs
  - Added SetNativeBackground* methods
  - Added documentation comments
  - Added IsWin7OrLater
  - Made sure all created image list were 32-bit

2011-05-18 22:52 (#554) - ObjectListView/VirtualObjectListView.cs, ObjectListView/Filtering/ClusteringStrategy.cs, ObjectListView/TreeListView.cs, ObjectListView/SubControls/ToolStripCheckedListBox.cs, ObjectListView/Filtering/Filters.cs, ObjectListView/Filtering/ClustersFromGroupsStrategy.cs, ObjectListView/ObjectListView2008.csproj, ObjectListView/Implementation/Enums.cs, ObjectListView/FastDataListView.cs, ObjectListView/Filtering/Cluster.cs, ObjectListView/Implementation/Events.cs, ObjectListView/Rendering/Decorations.cs, ObjectListView/Filtering/FilterMenuBuilder.cs, ObjectListView/CellEditing/CellEditKeyEngine.cs
  - Added/corrected documentation comments

2011-05-18 22:48 (#553) - docs/images/dragdrop-tlv.png, docs/blog.rst, docs/images/chili-smoothie.jpg, docs/samples.rst, docs/recipes.rst, docs/changelog.rst, docs/whatsnew.rst, docs/olv-sandcastle.shfbproj, docs/images/blog4-dropbetween.png, docs/images/blog4-emptyform.png, docs/blog4.rst, docs/images/blog4-infomessage.png, docs/images/dragdrop-tlv-small.png, docs/dragdrop.rst, docs/images/blog4-nodrop.png, docs/conf.py, docs/.static/blog4-icon.png, docs/images/blog4-basicform.png
  - Ready documentation for v2.5

2011-04-27 14:56 (#552) - ObjectListView/OLVColumn.cs
  - OLVColumn has its own file

2011-04-27 14:55 (#551) - ObjectListView/Utilities/ColumnSelectionForm.cs, ObjectListView/ObjectListView2010.csproj, ObjectListView/ObjectListView2005.csproj, ObjectListView/Utilities/ColumnSelectionForm.Designer.cs, ObjectListView/ObjectListView2008.csproj, ObjectListView/ObjectListView.csproj, ObjectListView/Properties/Resources.resx, ObjectListView/Utilities/ColumnSelectionForm.resx, ObjectListView/Properties/Resources.Designer.cs
  - VS2005 project now has 2005 suffix
  - Updated projects for 2.5b

2011-04-27 14:53 (#550) - ObjectListView/VirtualObjectListView.cs
  - CheckedObjects now only returns objects that are currently in the list.  ClearObjects() now resets all check state info.
  - Filtering on grouped virtual lists no longer behaves strangely.

2011-04-27 14:52 (#549) - ObjectListView/TreeListView.cs
  - Added ExpandedObjects property and RebuildAll() method.
  - Added Expanding, Collapsing, Expanded and Collapsed events. The ..ing events are cancellable. These are only fired in response to user actions.

2011-04-27 14:49 (#548) - ObjectListView/ObjectListView.cs
  - Added SubItemChecking event
  - Fixed bug in handling of NewValue on CellEditFinishing event
  - Added UseFilterIndicator
  - Added some more localizable messages
  - FormatCellEventArgs now has a CellValue property, which is the model value displayed by the cell.
  - Tweaked UseTranslucentSelection and UseTranslucentHotItem to look (a little) more like Vista/Win7.
  - Alternate colours are now only applied in Details view (as they always should have been)
  - Alternate colours are now correctly recalculated after removing objects
  - Added SelectColumnOnRightClickBehaviour to allow the selecting of columns mechanism to be changed. Can now be InlineMenu (the default), SubMenu, or ModelDialog.
  - ColumnSelectionForm was moved from the demo into the ObjectListView project itself.
  - Ctrl-C copying is now able to use the DragSource to create the data transfer object.

2011-04-27 14:47 (#547) - ObjectListView/FastObjectListView.cs
  - Fixed problem with removing objects from filtered or sorted list
  - Optimized EnumerableToArray()

2011-04-27 14:45 (#546) - ObjectListView/SubControls/HeaderControl.cs
  - Added ability to draw filter indicator in a column's header

2011-04-27 14:44 (#545) - ObjectListView/Rendering/Decorations.cs, ObjectListView/Rendering/TreeRenderer.cs
  - Added ability to have a gradient background on BorderDecoration
  - TreeRenderer has its own file

2011-04-27 14:43 (#544) - ObjectListView/Properties/AssemblyInfo.cs
  - Updated version info

2011-04-27 14:43 (#543) - ObjectListView/Implementation/OlvListViewHitTestInfo.cs, ObjectListView/Implementation/NullableDictionary.cs, ObjectListView/Implementation/OLVListItem.cs, ObjectListView/Implementation/Delegates.cs, ObjectListView/Implementation/GroupingParameters.cs, ObjectListView/Implementation/Enums.cs, ObjectListView/Implementation/Events.cs, ObjectListView/Implementation/OLVListSubItem.cs
  - Added new tree events
  - Separated many utility classes into their own files

2011-04-27 14:42 (#542) - ObjectListView/Filtering/ClusteringStrategy.cs, ObjectListView/Filtering/FirstLetterClusteringStrategy.cs, ObjectListView/Filtering/IClusteringStrategy.cs, ObjectListView/Filtering/ClustersFromGroupsStrategy.cs, ObjectListView/Filtering/FilterMenuBuilder.cs, ObjectListView/Filtering/DateTimeClusteringStrategy.cs
  - Formalized creating clusters from groups
  - Added some images to filter menu

2011-04-27 14:39 (#541) - ObjectListView/Resources, ObjectListView/Resources/clear-filter.png, ObjectListView/Resources/sort-ascending.png, ObjectListView/Resources/filter.png, ObjectListView/Resources/filter-icons3.png, ObjectListView/Resources/sort-descending.png
  - Added some images for OLV to use

2011-04-27 14:38 (#540) - ObjectListView/DragDrop, ObjectListView/DragDrop/DropSink.cs, ObjectListView/DragDrop/OLVDataObject.cs, ObjectListView/DragDrop/DragSource.cs
  - Moved to their own files

2011-04-27 14:38 (#539) - ObjectListView/CellEditing/EditorRegistry.cs
  - Use OLVColumn.DataType if the value to be edited is null

2011-04-27 14:36 (#538) - Tests/TestBasics.cs, Tests/Tests2005.csproj, Tests/Program.cs, Tests/Tests.csproj
  - Updated for v2.5b

2011-04-27 14:35 (#537) - ListViewPrinterDemo/Resources/compass16.png, ListViewPrinterDemo/ListViewPrinterDemo2005.csproj, ListViewPrinterDemo/ListViewPrinterDemo.csproj
  - Updated for v2.5b

2011-04-27 14:34 (#536) - ListViewPrinter/ListViewPrinter2005.csproj, ListViewPrinter/Properties/AssemblyInfo.cs, ListViewPrinter/ListViewPrinter.csproj
  - Updated for v2.5b

2011-04-27 14:33 (#535) - Demo/Resources/star16.png, Demo/ObjectListViewDemo2010.csproj, Demo/AssemblyInfo.cs, Demo/Resources/redbull.png, Demo/Resources/limeleaf.png, Demo/ObjectListViewDemo2005.csproj, Demo/Resources/goldstar3.png, Demo/ObjectListViewDemo2008.csproj, Demo/MainForm.resx, Demo/Photos/gab.png, Demo/Photos/ak.png, Demo/Photos/cp.png, Demo/Photos/cr.png, Demo/Photos/es.png, Demo/Photos/gp.png, Demo/Resources/tick16.png, Demo/Photos/jr.png, Demo/Photos/jp.png, Demo/Photos/mb.png, Demo/Photos/ns.png, Demo/Photos/np.png, Demo/MainForm.cs, Demo/Photos/sj.png, Demo/Photos/sp.png, Demo/Resources/down16.png, Demo/MainForm.Designer.cs, Demo/Resources/goldstart-32.png, Demo/Resources/fav32.png, Demo/Resources/redback1.png, Demo/Resources/movie16.png, Demo/Resources/music16.png, Demo/ObjectListViewDemo.csproj, Demo/Resources/folder16.png
  - Added WITHOUT_ANIMATION compile time switch so that the demo can work with VS 2005
  - Updated for v2.5b

2011-04-27 14:31 (#534) - docs/.static/listCtrlPrinter-icon.png, docs/images/gettingstarted-example6.png, docs/.static/filtering-icon.png, docs/.static/dialog2-blue-800x1600.png, docs/recipes.rst, docs/images/overlay.png, docs/.static/majorClasses-icon.png, docs/images/chili-smoothie2.jpg, docs/images/dragdrop-infomsg.png, docs/images/orange-800x1600.png, docs/.static/groupListView-icon.png, docs/.static/gettingStarted-icon.png, docs/images/treelistview.png, docs/images/fancy-screenshot2.png, docs/images/fancy-screenshot3.png, docs/images/dark-blue-800x1600.png, docs/images/blog3-listview2.png, docs/.static/download-icon.png, docs/images/blog2-balloon2.png, docs/images/blog2-balloon1.png, docs/images/blog-badscroll.png, docs/.static/overlays-icon.png, docs/images/gettingstarted-example3.png, docs/.static/features-icon.png, docs/images/redbull.jpg, docs/images/foobar-lookalike-small.png, docs/.static/whatsnew-icon.png, docs/images/hyperlinks.png, docs/images/tileview-example.png, docs/images/blog3-listview1a.png, docs/.static/dragdrop-icon.png, docs/.static/search-icon.png, docs/images/excel-filtering.png, docs/images/ownerdrawn-example1.png, docs/images/limeleaf.jpg, docs/images/text-filter-highlighting.png, docs/images/right-arrow.png, docs/images/image-renderer.png, docs/download.rst, docs/images/dragdrop-dropsubitem.png, docs/images/group-formatting.png, docs/whatsnew.rst, docs/images/flags-renderer.png, docs/images/blog-overlayimage.png, docs/images/images-renderer.png, docs/index.rst, docs/images/blog3-listview3.png, docs/images/dragdrop-dropbackground.png, docs/.static/blog3-icon.png, docs/.static/blog2-icon.png, docs/images/light-blue-800x1600.png, docs/.static/blog1-icon.png, docs/images/header-with-image.png, docs/images/ModelToScreenProcess.png, docs/images/ReportModernExample.jpg, docs/images/gettingstarted-example4.png, docs/images/mappedimage-renderer.png, docs/images/dragdrop-example1.png, docs/images/fancy-screenshot.png, docs/images/dragdrop-feedbackcolor.png, docs/.static/recipes-icon.png, docs/images/multiimage-renderer.png, docs/.static/samples-icon.png, docs/images/tileview-ownerdrawn.png, docs/.static/faq-icon.png, docs/images/cell-editing-border.png, docs/.static/cellEditing-icon.png, docs/images/bar-renderer.png, docs/images/icecream3.jpg, docs/changelog.rst, docs/images/emptylistmsg-example.png, docs/.static/changelog-icon.png, docs/images/ClassDiagram-VirtualList.png, docs/images/blog3-listview4.png, docs/images/printpreview.png, docs/.static/index-icon.png, docs/images/gettingstarted-example1.png, docs/.static/orange-800x1600.png, docs/images/gettingstarted-example5.png, docs/images/vertical-header.png, docs/filtering.rst, docs/.static/animations-icon.png, docs/images/ClassDiagram.png, docs/images/dragdrop-dropbetween.png, docs/images/smoothie2.jpg, docs/.static/dark-blue-800x1600.png, docs/images/blog-setbkimage.png, docs/images/task-list.png, docs/images/foobar-lookalike.png, docs/images/coffee.jpg, docs/overlays.rst, docs/images/header-formatting.png, docs/images/task-list-small.png, docs/.static/blog-icon.png, docs/images/ObjectListView.jpg, docs/.static/light-blue-800x1600.png, docs/images/blog3-listview1.png, docs/images/dialog2-blue-800x1600.png, docs/.static/ownerDraw-icon.png, docs/conf.py, docs/images/decorations-example.png, docs/images/gettingstarted-example2.png
  - Updated docs for v2.5b

2011-03-21 22:34 (#533) - SparkleLibrary/keyfile.pfx, Demo/ObjectListViewDemo2010.csproj, Tests/Tests2010.csproj, SparkleLibrary/SparkleLibrary2010.csproj, ListViewPrinter/ListViewPrinter2010.csproj, ListViewPrinterDemo/ListViewPrinterDemo2010.csproj
  - Added VS 2010 support

2011-03-21 22:33 (#532) - Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/ShellUtilities.cs, Demo/MainForm.resx
  - v2.5 alpha

2011-03-21 22:31 (#531) - ObjectListView2010.sln
  - Added VS 2010 support

2011-03-21 22:28 (#530) - ObjectListView/SubControls/ToolStripCheckedListBox.cs
  - Initial version

2011-03-21 22:21 (#526) - ObjectListView/Implementation/DataSourceAdapter.cs
  - Initial version

2011-03-21 21:34 (#521) - ObjectListView/CellEditing/EditorRegistry.cs, ObjectListView/CellEditing/CellEditors.cs, ObjectListView/CellEditing/CellEditKeyEngine.cs
  - Initial version of CellEditKeyEngine.cs
  - Separated EditorRegistry from CellEditors

2011-03-21 21:27 (#519) - ObjectListView/ObjectListView.cs
  - v2.5 alpha
  - [Big] Added Excel-style filtering. Right click on a header to show a Filtering menu.
  - [Big] Added CellEditKeyEngine to allow key handling to be completely customised. Add CellEditTabChangesRows and CellEditEnterChangesRows to show some of these abilities.
  - All model object comparisons now use Equals rather than == (thanks to vulkanino)
  - [Small Break] GetNextItem() and GetPreviousItem() now accept and return OLVListView rather than ListViewItems.
  - Added OLVColumn.AutoCompleteEditorMode in preference to AutoCompleteEditor  (which is now just a wrapper). Thanks to Clive Haskins
  - Added IncludeColumnHeadersInCopy
  - Added Freezing event
  - Preserve word wrap settings on TreeListView
  - Resize last group to keep it on screen
  - Fixed (once and for all) DisplayIndex problem with Generator
  - Changed the serializer used in SaveState()/RestoreState() so that it resolves on

2011-03-21 21:22 (#518) - ObjectListView/VirtualGroups.cs
  - Correctly honor group comparer, collapsible groups and GroupByOrder being None.

2011-03-21 21:20 (#517) - ObjectListView/Renderers.cs
  - Turning on word wrapping now enables GDI+ rendering (which it requires)
  - Trying to use animated gifs in a virtual list no longer crashes. It still doesn't work, but it doesn't crash.

2011-03-21 21:14 (#516) - ObjectListView/NativeMethods.cs
  - Added HasHorizontalScrollBar

2011-03-21 21:11 (#515) - ObjectListView/HeaderControl.cs
  - Correctly handle ShowSortIndicators being false
  - Allow a delegate to owner draw the header

2011-03-21 21:10 (#514) - ObjectListView/Groups.cs
  - No significant change

2011-03-21 21:09 (#513) - ObjectListView/Filters.cs
  - Added CompositeAllFilter, CompositeAnyFilter and OneOfFilter

2011-03-21 21:08 (#512) - ObjectListView/Events.cs
  - Added Freezing event

2011-03-21 21:07 (#511) - ObjectListView/DragSource.cs
  - Added IncludeColumnHeadersInCopy

2011-03-21 21:04 (#510) - ObjectListView/VirtualObjectListView.cs
  - BREAKING CHANGE: 'DataSource' was renamed to 'VirtualListDataSource'. This was necessary to allow FastDataListView which is both a DataListView AND a VirtualListView -- which both used a 'DataSource' property :(
  - Virtual lists can (finally) set CheckBoxes back to false if it has been set to true. (this is a little hacky and may not work reliably).
  - GetNextItem() and GetPreviousItem() now work on grouped virtual lists.

2011-03-21 21:02 (#509) - ObjectListView/TreeListView.cs
  - Changed to use VirtualListDataSource
  - Preserve word wrapping on tree column
  - [SMALL CHANGE] Renderer for tree column must now be a subclass of TreeRenderer

2011-03-21 20:59 (#508) - ObjectListView/ObjectListView2010.csproj, ObjectListView/ObjectListView2008.csproj, ObjectListView/ObjectListView.csproj
  - Reorganized files
  - Added VS 2010 project
  - Updated VS 2005 project

2011-03-21 20:58 (#507) - ObjectListView/FastObjectListView.cs
  - Changed to use VirtualListDataSource

2011-03-21 20:57 (#506) - ObjectListView/FastDataListView.cs
  - First version

2011-03-21 20:55 (#505) - ObjectListView/DataListView.cs
  - Moved most of the logic to DataSourceAdapter (where it can be used by FastDataListView too)

2010-11-16 21:38 (#498) - Tests/TestGenerator.cs
  - Added tests for DisplayIndex used in Generator

2010-11-16 21:38 (#497) - ObjectListView/ObjectListView.cs, ObjectListView/Attributes.cs, ObjectListView/Generator.cs
  - Fixed (once and for all) DisplayIndex problem with Generator
  - Changed the serializer used in SaveState()/RestoreState() so that it resolves on class name alone.
  - Fixed bug in GroupWithItemCountSingularFormatOrDefault
  - Fixed strange flickering in grouped, owner drawn OLV's using RefreshObject()

2010-11-10 05:24 (#496) - ObjectListView/ObjectListView.cs
  - Fixed problem with newly added columns in the AllColumns collection always coming to the front
  - Fixed flickering problem involving owner drawn, grouped OLV on Vista and Win7 when using RefreshObjects()
  - Added lots of documentation comments

2010-11-10 05:22 (#495) - ListViewPrinter/ListViewPrinter2008.csproj, ListViewPrinter/lvp-keyfile.snk, ListViewPrinter/BrushForm.cs
  - Added strong name key file

2010-11-10 05:21 (#494) - Tests/TestMunger.cs, Tests/Program.cs, Tests/Tests2008.csproj
  - Added new munger tests

2010-11-10 05:20 (#493) - Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Tweaked slightly

2010-11-10 05:19 (#492) - docs/whatsnew.rst, docs/olv-sandcastle.shfbproj, docs/.static/structure.css, docs/index.rst, docs/Help/ObjectListView-Documentation.chm, docs/.static/initial.css, docs/recipes.rst, docs/.templates/layout.html, docs/download.rst, docs/Help, docs/changelog.rst, docs/gettingStarted.rst
  - Updated docs for v2.4.1

2010-11-10 05:17 (#491) - ObjectListView/CellEditors.cs, ObjectListView/Overlays.cs, ObjectListView/TreeListView.cs, ObjectListView/Filters.cs, ObjectListView/Renderers.cs, ObjectListView/ToolTipControl.cs, ObjectListView/Munger.cs, ObjectListView/GlassPanelForm.cs, ObjectListView/VirtualGroups.cs, ObjectListView/DragSource.cs, ObjectListView/HeaderControl.cs, ObjectListView/FastObjectListView.cs, ObjectListView/VirtualObjectListView.cs, ObjectListView/NativeMethods.cs, ObjectListView/TypedObjectListView.cs, ObjectListView/DataListView.cs, ObjectListView/VirtualListDataSource.cs, ObjectListView/Decorations.cs, ObjectListView/Styles.cs, ObjectListView/ObjectListView2008.csproj, ObjectListView/Adornments.cs, ObjectListView/Events.cs, ObjectListView/DropSink.cs, ObjectListView/Comparers.cs, ObjectListView/ObjectListView.DesignTime.cs, ObjectListView/Groups.cs, ObjectListView/Generator.cs, ObjectListView/Attributes.cs
  - Added lots of documentation comments



v2.4.1 - 15 September 2010
--------------------------

2010-08-31 23:30 (#489) - ObjectListView/ObjectListView.cs
  - Don't try to call native methods when the control hasn't been created

2010-08-31 23:06 (#488) - ObjectListView/Properties/AssemblyInfo.cs
  - Changed version number to 2.4.1

2010-08-31 23:06 (#487) - Demo/AssemblyInfo.cs, Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Update some group images

2010-08-28 15:32 (#486) - ObjectListView/TreeListView.cs
  - Merged IDE "Appearance" and "Behavior" categories into single "ObjectListView" category

2010-08-28 15:32 (#485) - ObjectListView/Renderers.cs
  - Merged IDE "Appearance" and "Behavior" categories into single "ObjectListView" category

2010-08-28 15:30 (#484) - ObjectListView/ObjectListView.cs
  - Fixed bug where setting OLVColumn.CheckBoxes to false gave it a renderer specialized for checkboxes. Oddly, this made Generator created owner drawn lists appear to be completely empty.
  - In IDE, all ObjectListView properties are now in a single "ObjectListView" category, rather than splitting them between "Appearance" and "Behavior" categories.
  - Added GroupingParameters.GroupComparer to allow groups to be sorted in a customizable fashion.
  - Sorting of items within a group can be disabled by setting GroupingParameters.PrimarySortOrder to None.

2010-08-28 15:29 (#483) - ObjectListView/Generator.cs
  - Generator now reset sort column too

2010-08-28 15:28 (#482) - ObjectListView/CellEditors.cs, ObjectListView/Overlays.cs, ObjectListView/Adornments.cs, ObjectListView/CustomDictionary.xml, ObjectListView/Events.cs, ObjectListView/DropSink.cs, ObjectListView/Comparers.cs
  - Merged IDE "Appearance" and "Behavior" categories into single "ObjectListView" category

2010-08-28 15:27 (#481) - Demo/Resource1.Designer.cs, Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/ShellUtilities.cs, Demo/MainForm.resx
  - Update ready for v2.4.1
  - SysImageListHelper now uses 32 bit images by default

2010-08-28 15:26 (#480) - docs/features.rst, docs/images/vertical-header.png, docs/whatsnew.rst, docs/images/cell-editing-border.png, docs/conf.py, docs/recipes.rst, docs/images/header-with-image.png, docs/.templates/layout.html, docs/changelog.rst
  - Update ready for v2.4.1

2010-08-24 21:23 (#479) - ObjectListView/Renderers.cs
  - CheckBoxRenderer handles hot boxes and correctly vertically centers the box.

2010-08-24 21:22 (#478) - ObjectListView/ObjectListView.cs
  - Added OLVColumn.IsHeaderVertical to make a column draw its header vertical.
  - Added OLVColumn.HeaderTextAlign to control the alignment of a column's header text.
  - Added HeaderMaximumHeight to limit how tall the header section can become

2010-08-24 21:22 (#477) - ObjectListView/HeaderControl.cs
  - Added ability to draw header vertically (thanks to Mark Fenwick)
  - Uses OLVColumn.HeaderTextAlign to decide how to align the column's header

2010-08-24 21:22 (#476) - ObjectListView/DropSink.cs
  - Moved AcceptExternal property up to SimpleDragSource.

2010-08-18 20:23 (#475) - ObjectListView/olv-keyfile.snk, ObjectListView/ObjectListView2008.csproj, ObjectListView/keyfile.pfx
  - Use strong named key to sign the assembly

2010-08-18 20:21 (#474) - ObjectListView/GlassPanelForm.cs
  - Added WS_EX_TOOLWINDOW style so that the form won't appear in Alt-Tab list.

2010-08-18 20:21 (#473) - ObjectListView/DragSource.cs
  - Allow hidden columns to be included in the data transfer

2010-08-18 20:20 (#472) - ObjectListView/ObjectListView.cs
  - Fixed long standing bug where having 0 columns caused a InvalidCast exception.
  - Added IncludeAllColumnsInDataObject property
  - Improved BuildList(bool) so that it preserves scroll position even when the listview is grouped.

2010-08-18 20:19 (#471) - SparkleLibrary/SparkleLibrary.csproj, SparkleLibrary/sparkle-keyfile.snk, SparkleLibrary/Sprites/TextSprite.cs
  - Use strong named key to sign the assembly

2010-08-12 11:51 (#470) - ObjectListView/ObjectListView.cs
  - Removed testing value from HeaderImageKey

2010-08-12 11:47 (#469) - ObjectListView/Renderers.cs
  - CheckStateRenderer now handles hot and disabled states

2010-08-12 11:45 (#468) - ObjectListView/ObjectListView.cs
  - Added OLVColumn.HeaderImageKey to allow column headers to have an image.
  - CellEdit validation and finish events now have NewValue property.
  - Subitem checkboxes improvments: obey IsEditable, can be hot, can be disabled.
  - No more flickering of selection when tabbing between cells
  - Added ObjectListView.SmoothingMode to control the smoothing of all graphics operations
  - Columns now cache their group item format strings so that they still work as  grouping columns after they have been removed from the listview. This cached value is only used when the column is not part of the listview.

2010-08-12 11:44 (#467) - ObjectListView/ObjectListView2008.csproj, ObjectListView/keyfile.pfx
  - Signed DLL

2010-08-12 11:43 (#466) - ObjectListView/Munger.cs
  - Refactored into Munger/SimpleMunger. 3x faster!

2010-08-12 11:43 (#465) - ObjectListView/HeaderControl.cs
  - Added ability to have image in header

2010-08-12 11:42 (#464) - ObjectListView/GlassPanelForm.cs
  - Use ObjectListView.SmoothingMode

2010-08-12 11:42 (#463) - ObjectListView/Filters.cs
  - Slight code cleanup

2010-08-12 11:41 (#462) - ObjectListView/Events.cs
  - CellEdit validation and finish events now have NewValue property.

2010-08-12 11:41 (#461) - ObjectListView/DropSink.cs
  - Use ObjectListView.SmoothingMode

2010-08-12 11:40 (#460) - ObjectListView/Decorations.cs
  - Tweak LightBoxDecoration under Tile view

2010-07-25 18:53 (#459) - ObjectListView/Decorations.cs
  - Added EditingCellBorderDecoration

2010-07-25 18:52 (#458) - ObjectListView/FastObjectListView.cs, ObjectListView/VirtualObjectListView.cs, ObjectListView/ObjectListView.cs
  - Added Unsort method
  - Correctly trigger a Click event when the mouse is clicked.
  - Invalidate the control before and after cell editing to make sure it looks right
  - Right mouse clicks on checkboxes no longer confuse them

2010-07-25 18:50 (#457) - ObjectListView/Overlays.cs, ObjectListView/NativeMethods.cs, ObjectListView/TreeListView.cs, ObjectListView/Styles.cs, ObjectListView/Adornments.cs, ObjectListView/CustomDictionary.xml, ObjectListView/DropSink.cs, ObjectListView/ObjectListView.DesignTime.cs, ObjectListView/ObjectListView.FxCop, ObjectListView/ToolTipControl.cs, ObjectListView/VirtualGroups.cs
  - Corrected a few FxCop annoyances

2010-07-25 18:47 (#456) - Tests/TestSorting.cs
  - Added Unsort tests

2010-06-23 22:11 (#455) - ObjectListView/VirtualObjectListView.cs
  - Changed name IsVista -> IsVistaOrLater

2010-06-23 22:10 (#454) - ObjectListView/TreeListView.cs
  - Fixed bug in Tree.RemoveObjects() which resulted in removed objects being reported as still existing.

2010-06-23 22:09 (#453) - ObjectListView/ToolTipControl.cs
  - Changed name IsVista -> IsVistaOrLater

2010-06-23 22:08 (#452) - ObjectListView/Renderers.cs
  - Major rework of HighlightTextRenderer. Now uses TextMatchFilter directly. Draw highlighting underneath text to improve legibility. Works with new TextMatchFilter FindAll capabilities. Can draw rounded rectangle frame

2010-06-23 22:06 (#451) - ObjectListView/NativeMethods.cs, ObjectListView/ObjectListView.cs
  - Avoid bug in underlying ListView control where virtual lists in SmallIcon view generate GETTOOLINFO msgs with invalid item indicies.
  - Fixed bug where FastObjectListView would throw an exception when showing hyperlinks in any view except Details.
  - Renamed IsVista property to IsVistaOrLater which more accurately describes its function.
  - - Fixed bug in ChangeToFilteredColumns() that resulted in column display order being lost when a column was hidden.

2010-06-23 22:04 (#450) - ObjectListView/Filters.cs
  - Gave TextMatchFilter the ability to find all matches in a string
  - Better handle invalid regexs in TextMatchFilter

2010-06-23 22:03 (#449) - ObjectListView/FastObjectListView.cs
  - Fix RemoveObjects() so it works with new filtering scheme

2010-06-23 22:02 (#448) - ObjectListView/Events.cs
  - Reduced wait between validate events (need a better solution)

2010-06-23 22:01 (#447) - Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Gave filter on Fast tab the ability to use regex, prefix or normal matching

2010-06-23 22:00 (#446) - Tests/TestFilters.cs, Tests/TestFormatting.cs, Tests/TestBasics.cs
  - Added tests for AddObjects and RemoveObjects
  - Added Filter FindAll tests

2010-06-10 23:16 (#445) - ObjectListView/Filters.cs, Tests/TestFilters.cs, Tests/Program.cs, ObjectListView/ObjectListView.cs
  - Upgrade TextMatchFilter. Now handles prefix matching and regex's
  - OLVColumn.ValueToString() always returns a String (as it always should have)

2010-05-17 20:09 (#444) - docs/.static/animations-icon.png, ObjectListView/Renderers.cs, ObjectListView/ObjectListView.cs, docs/changelog.rst
  - Added OLVColumn.WordWrap, which should always have been there

2010-04-26 07:52 (#442) - Tests/TestGenerator.cs
  - Added test for new attributes

2010-04-25 20:06 (#441) - docs/.static/objectListView-animation.swf, docs/.static/swfobject_modified.js, docs/.static/expressInstall.swf, docs/.static/sparkle-garish-example.swf, docs/.static/objectlistview-animations.html, docs/recipes.rst, docs/.static/sparkle-animations.html, docs/faq.rst, docs/.templates/layout.html, docs/download.rst, docs/changelog.rst, docs/features.rst, docs/.static/sparkle-simple-example.swf, docs/whatsnew.rst, docs/index.rst, docs/.static/objectListView-simple-animation.swf, docs/animations.rst
  - Ready for v2.4 release

2010-04-25 20:02 (#440) - Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - v2.4 release



v2.4 - 17 April 2010
--------------------

2010-04-17 00:13 (#439) - ObjectListView/ObjectListView.cs
  - Prevent object disposed errors when mouse event handlers cause the ObjectListView to be destroyed (e.g. closing a form during a  double click event).
  - Avoid checkbox munging bug in standard ListView when shift clicking on non-primary columns when FullRowSelect is true.
  - Fixed bug in group sorting (thanks Mike).
  - Prevent hyperlink processing from triggering spurious MouseUp events. This showed itself by launching the same url multiple times.
  - Space filling columns correctly resize upon initial display
  - ShowHeaderInAllViews is better but still not working reliably.

2010-04-16 23:07 (#438) - ObjectListView/HeaderControl.cs, ObjectListView/FastObjectListView.cs, ObjectListView/Filters.cs, ObjectListView/VirtualListDataSource.cs, ObjectListView/Styles.cs, ObjectListView/Events.cs, ObjectListView/Renderers.cs
  - Added v2.4 tag

2010-04-16 23:06 (#437) - ObjectListView/VirtualObjectListView.cs
  - Removed rogue debug statements

2010-04-16 23:05 (#436) - ObjectListView/ToolTipControl.cs
  - Removed rogue debug statements

2010-04-16 23:04 (#435) - ObjectListView/GlassPanelForm.cs
  - Documented the change I committed last time

2010-04-16 23:02 (#434) - ObjectListView/Decorations.cs
  - Tweaked LightBoxDecoration a little

2010-04-16 23:01 (#433) - ObjectListView/Attributes.cs, ObjectListView/Generator.cs
  - Allow Name property to be set
  - Don't double set the Text property

2010-04-16 23:00 (#432) - ObjectListView/Properties/AssemblyInfo.cs
  - Updated to v2.4

2010-04-16 22:58 (#431) - SparkleLibrary/Locators/RectangleLocator.cs, SparkleLibrary/Sprites/ShapeSprite.cs, SparkleLibrary/Sprites/Audio.cs, SparkleLibrary/Sprites/TextSprite.cs, SparkleLibrary/Locators/Locators.cs, SparkleLibrary/Animation/Animateable.cs, SparkleLibrary/Animation/Events.cs, SparkleLibrary/Locators/PointLocator.cs, SparkleLibrary/Animation/Animation.cs, SparkleLibrary/Effects/Effects.cs, SparkleLibrary/Sprites/ImageSprite.cs, SparkleLibrary/Effects/Effect.cs, SparkleLibrary/Sprites/Sprite.cs, SparkleLibrary/Adapters/AnimationAdapter.cs, SparkleLibrary/Sprites/ISprite.cs
  - Improved documentation
  - Improved (?) compatibility with VS 2005

2010-03-25 20:32 (#430) - Demo/Resources/goldstart-32.png, Demo/Resources/goldstar3.png
  - Added images missing from v2.4b release

2010-03-24 23:56 (#429) - SparkleLibrary/SparkleLibrary.csproj, SparkleLibrary/Locators/RectangleLocator.cs, SparkleLibrary/Sprites/Audio.cs, SparkleLibrary/Sprites/TextSprite.cs, SparkleLibrary, SparkleLibrary/Effects, SparkleLibrary/Sprites, SparkleLibrary/Animation/Events.cs, SparkleLibrary/Animation/Animation.cs, SparkleLibrary/Effects/Effects.cs, SparkleLibrary/Sprites/ImageSprite.cs, SparkleLibrary/Animation, SparkleLibrary/Sprites/ISprite.cs, SparkleLibrary/Sprites/ShapeSprite.cs, SparkleLibrary/Locators/Locators.cs, SparkleLibrary/Properties/AssemblyInfo.cs, SparkleLibrary/Animation/Animateable.cs, SparkleLibrary/Locators, SparkleLibrary/Properties, SparkleLibrary/Locators/PointLocator.cs, SparkleLibrary/Adapters, SparkleLibrary/Effects/Effect.cs, SparkleLibrary/Sprites/Sprite.cs, SparkleLibrary/Adapters/AnimationAdapter.cs
  - v2.4 beta

2010-03-24 23:53 (#428) - Demo/AnimatedDecoration.cs, ObjectListView/Filters.cs, docs/recipes.rst, Demo/Resource1.Designer.cs, Demo/ObjectListViewDemo2008.csproj, ObjectListView/ObjectListView.cs, docs/.templates/layout.html, ObjectListView/GlassPanelForm.cs, Demo/MainForm.resx, ObjectListView/VirtualGroups.cs, ObjectListView/HeaderControl.cs, ObjectListView/Styles.cs, ObjectListView/Events.cs, Demo/MainForm.cs, docs/animations.rst, Demo/MainForm.Designer.cs, Demo/Resource1.resx, ObjectListView/TreeListView.cs, docs/images/text-filter-highlighting.png, ObjectListView/Renderers.cs, docs/faq.rst, docs/download.rst, ObjectListView/FastObjectListView.cs, ObjectListView/VirtualObjectListView.cs, ObjectListView/VirtualListDataSource.cs, docs/index.rst, Tests/TestFilters.cs, ObjectListView/Adornments.cs, ObjectListView/ObjectListView2008.csproj, docs/conf.py, ObjectListView2008.sln, ListViewPrinter/ListViewPrinter.cs, Tests/Tests2008.csproj
  - v2.4 beta

2010-01-19 23:14 (#427) - ObjectListView/ObjectListView.cs
  - Overlays can be turned off. They also only work on 32-bit displays

2010-01-19 23:13 (#426) - ObjectListView/DragSource.cs
  - Added methods to support make HTML from selected objects

2009-10-31 07:05 (#425) - ObjectListView/Renderers.cs, ObjectListView/ObjectListView.cs
  - Plugged possible resource leak by using using() with CreateGraphics()

2009-10-31 07:05 (#424) - ObjectListView/HeaderControl.cs
  - Plugged GDI resource leak, where font handles were created during custom drawing, but never destroyed

2009-10-31 06:59 (#423) - ObjectListView/ObjectListView.cs
  - Fix bug when right clicking in the empty area of the header
  - Redraw the control after setting EmptyListMsg property

2009-10-31 06:58 (#422) - ObjectListView/GlassPanelForm.cs
  - Use FindForm() rather than TopMostControl, since the latter doesn't work as I expected when the OLV is part of an MDI child window. Thanks to wvd_vegt who tracked this down.

2009-10-31 06:34 (#421) - ObjectListView/CellEditors.cs, ObjectListView/Overlays.cs, ObjectListView/TreeListView.cs, docs/samples.rst, ObjectListView/Renderers.cs, docs/.templates/layout.html, ObjectListView/ToolTipControl.cs, ObjectListView/Munger.cs, docs/changelog.rst, ObjectListView/VirtualGroups.cs, ObjectListView/DragSource.cs, ObjectListView/HeaderControl.cs, ObjectListView/FastObjectListView.cs, ObjectListView/VirtualObjectListView.cs, ObjectListView/NativeMethods.cs, ObjectListView/TypedObjectListView.cs, docs/index.rst, ObjectListView/DataListView.cs, ObjectListView/VirtualListDataSource.cs, ObjectListView/Decorations.cs, docs/images/fancy-screenshot2.png, ObjectListView/Styles.cs, ObjectListView/Adornments.cs, ObjectListView/Events.cs, ObjectListView/DropSink.cs, ObjectListView/Comparers.cs, ObjectListView/ObjectListView.DesignTime.cs, ObjectListView/Groups.cs, ObjectListView/Generator.cs, ObjectListView/Attributes.cs
  - Added "v2.3" tag



v2.3 - 14 October 2009
----------------------

2009-10-14 07:48 (#419) - ObjectListView/Properties/AssemblyInfo.cs, ObjectListView/Overlays.cs, Demo/AssemblyInfo.cs, docs/recipes.rst, docs/samples.rst, Demo/Resource1.Designer.cs, Demo/MainForm.resx, ObjectListView/GlassPanelForm.cs, ObjectListView/HeaderControl.cs, Demo/Photos/gab.png, ObjectListView/NativeMethods.cs, Tests/SetupTestSuite.cs, docs/images/fancy-screenshot2.png, docs/images/fancy-screenshot3.png, ObjectListView/Styles.cs, Tests/TestTreeView.cs, Demo/MainForm.cs, ObjectListView/ObjectListView.DesignTime.cs, ObjectListView/Groups.cs, Demo/MainForm.Designer.cs, Demo/Resource1.resx, docs/images/foobar-lookalike-small.png, docs/images/hyperlinks.png, ObjectListView/TreeListView.cs, Tests/TestSelection.cs, Demo/Resources/fav32.png, ObjectListView/ObjectListView.csproj, ObjectListView/Renderers.cs, docs/faq.rst, docs/download.rst, ObjectListView/ToolTipControl.cs, docs/images/group-formatting.png, Tests/Tests.csproj, Tests/TestGenerator.cs, docs/whatsnew.rst, ObjectListView/VirtualObjectListView.cs, docs/index.rst, docs/dragdrop.rst, ObjectListView/Adornments.cs, Tests/Program.cs, ObjectListView/Generator.cs, Tests/TestSorting.cs, docs/.static/samples-icon.png, Tests/TestCheckBoxes.cs, Demo/ObjectListViewDemo2008.csproj, ObjectListView/ObjectListView.cs, docs/.templates/layout.html, ObjectListView/VirtualGroups.cs, docs/features.rst, Demo/Photos/ak.png, Demo/Photos/cp.png, Demo/Photos/cr.png, Demo/Photos/es.png, Demo/Photos/gp.png, ObjectListView/Decorations.cs, Demo/Photos/jr.png, Demo/Photos/jp.png, Tests/TestFormatting.cs, Demo/Photos/mb.png, ObjectListView/Events.cs, Demo/Photos/np.png, Demo/Photos/ns.png, Demo/Photos/sp.png, Demo/Photos/sj.png, Tests/TestAdornments.cs, ObjectListView/Comparers.cs, Tests/MainForm.cs, ObjectListView/CellEditors.cs, docs/images/task-list.png, Tests/TestBasics.cs, ListViewPrinterDemo/Properties/Settings.Designer.cs, docs/images/foobar-lookalike.png, docs/gettingStarted.rst, ObjectListView/FastObjectListView.cs, ListViewPrinterDemo/Properties/Resources.Designer.cs, docs/images/header-formatting.png, ObjectListView/TypedObjectListView.cs, Tests/TestColumn.cs, ObjectListView/VirtualListDataSource.cs, docs/images/task-list-small.png, ObjectListView/ObjectListView2008.csproj, docs/conf.py, Tests/MainForm.Designer.cs, docs/images/decorations-example.png, Demo/ObjectListViewDemo.csproj, ListViewPrinter/ListViewPrinter.cs, Tests/Tests2008.csproj, ObjectListView/Attributes.cs
  - v2.3 release

2009-09-03 00:49 (#399) - ObjectListView/DropSink.cs
  - Correctly handle case where RefreshObjects() is called for objects that were children but are now roots.

2009-08-28 14:51 (#376) - ObjectListView/DropSink.cs
  - Added ModelDropEventArgs.RefreshObjects() to simplify updating after a drag-drop operation
  - Changed to use OlvHitTest()

2009-08-28 14:49 (#375) - ObjectListView/TreeListView.cs
  - Fixed bug when dragging a node from one place to another in the tree



v2.2.1 - 08 August 2009
-----------------------

2009-08-07 18:57 (#370) - ObjectListView/ObjectListView.cs
  - Subitem edit rectangles always allowed for an image in the cell, even if there was none. Now they only allow for an image when there actually is one.
  - Renamed CalculateTightCellBounds() CalculateCellTextBounds()
  - Added Bounds property to OLVListItem which handles items being part of collapsed groups.
  - Changing the hot item is now done within a BeginUpdate/EndUpdate pair

2009-08-07 18:54 (#369) - ObjectListView/TreeListView.cs
  - Ignore mouse clicks to the left of the expand button even when that row doesn't have an expand button

2009-08-07 18:52 (#368) - ObjectListView/Renderers.cs
  - When calculating the edit rectangle, don't try to get subitem info if there is no subitem

2009-08-07 18:52 (#367) - ObjectListView/Overlays.cs
  - TintedColumnDecoration now works when last item is member of a collapsed group

2009-08-07 18:50 (#366) - ObjectListView/DropSink.cs
  - Renamed CalculateTightCellBounds() CalculateCellTextBounds()

2009-08-07 18:48 (#365) - Demo/MainForm.cs, Demo/ObjectListViewDemo2008.csproj, Demo/MainForm.Designer.cs, Demo/ShellUtilities.cs, Demo/MainForm.resx
  - Updated for v2.2.1
  - ShellUtilities no longer caches the image lists

2009-08-07 18:43 (#364) - docs/images/blog3-listview1a.png, docs/blog.rst, docs/recipes.rst, docs/download.rst, docs/.templates/layout.html, docs/changelog.rst, docs/features.rst, docs/ownerDraw.rst, docs/whatsnew.rst, docs/blog3.rst, docs/blog2.rst, docs/blog1.rst, docs/index.rst, docs/images/blog3-listview1.png, docs/images/blog3-listview2.png, docs/conf.py, docs/images/blog3-listview3.png, docs/Sitemap.xml, docs/images/blog3-listview4.png, docs/.static/blog2-icon.png, docs/.static/blog1-icon.png, docs/.static/blog3-icon.png, docs/images/blog2-balloon2.png, docs/images/blog2-balloon1.png, docs/.static/overlays-icon.png
  - Update docs for v2.2.1
  - Added new blog entries

2009-07-27 16:48 (#363) - ObjectListView/ObjectListView.cs
  - Avoided bug in .NET framework involving column 0 of owner drawn listviews not being redrawn when the listview was scrolled horizontally.
  - The cell edit rectangle is now correctly calculated when the listview is scrolled horizontally.

2009-07-27 16:47 (#362) - ObjectListView/VirtualObjectListView.cs
  - Added specialised version of RefreshSelectedObjects() which works efficiently with virtual lists (thanks to chriss85 for finding this bug)

2009-07-27 16:46 (#361) - ObjectListView/Renderers.cs
  - Try to honour CanWrap setting when GDI rendering text.

2009-07-27 16:45 (#360) - ObjectListView/Overlays.cs
  - TintedColumnDecoration now works when last item is a member of a collapsed group (well, it no longer crashes).

2009-07-27 16:44 (#359) - ObjectListView/NativeMethods.cs
  - Added GetScrolledColumnSides() and SetToolTipControl()

2009-07-15 06:58 (#358) - ObjectListView/ObjectListView.cs
  - Added CellOver event
  - If the user clicks/double clicks on a tree list cell, an edit operation will not begin if the click was to the left of the expander. This is implemented in such a way that other renderers can have similar "dead" zones.

2009-07-15 06:56 (#357) - ObjectListView/TreeListView.cs
  - Clicks to the left of the expander in tree cells are now ignored.

2009-07-12 16:45 (#356) - ObjectListView/ObjectListView.cs
  - Added Cell events
  - CalculateCellBounds() used to mess with the FullRowSelect property, which confused the tooltip handling on the underlying control. It no longer does this.
  - If the user clicks/double clicks on a cell, an edit operation will begin only if the clicks were on the image or text.
  - The cell edit rectangle is now correctly calculated for owner-drawn, non-Details views.
  - Made BuildList(), AddObject() and RemoveObject() thread-safe

2009-07-12 16:42 (#355) - ObjectListView/Renderers.cs
  - Correctly calculate edit rectangle for subitems of a tree view (previously subitems were indented in the same way as the primary column)
  - Standardized code format

2009-07-12 16:41 (#354) - ObjectListView/ToolTipControl.cs
  - Moved ToolTipShowingEventArgs to Events.cs

2009-07-12 16:40 (#353) - ObjectListView/Events.cs
  - Added Cell events
  - Moved all event parameter blocks to this file.
  - Added Handled property to AfterSearchEventArgs

2009-07-07 06:41 (#352) - ObjectListView/VirtualObjectListView.cs
  - Don't bother trying to fetch model objects in GetModelObject() if the index is negative

2009-07-07 06:40 (#351) - ObjectListView/DropSink.cs
  - Added StandardDropActionFromKeys property to OlvDropEventArgs

2009-07-07 06:39 (#350) - ObjectListView/DragSource.cs
  - Make sure Link is acceptable as an drop effect by default

2009-07-04 20:17 (#349) - ObjectListView/ObjectListView.cs
  - Space bar now properly toggles checkedness of selected rows

2009-07-03 22:39 (#348) - ObjectListView/ObjectListView.cs
  - Fixed bug with tooltips when the underlying Windows control was destroyed.
  - CellToolTipShowing events are now triggered in all views.

2009-06-09 00:01 (#344) - ObjectListView/NativeMethods.cs
  - Fixed bug in GetWindowLong/SetWindowLong that appears on 64-bit OSes



v2.2 - 08 June 2009
-------------------

2009-06-08 03:53 (#343) - docs/features.rst, docs/index.rst, docs/recipes.rst, docs/faq.rst
  - Added two more recipes
  - Add info about collapsible groups

2009-06-08 03:52 (#342) - Demo/MainForm.cs
  - Don't use tool tip balloons under Vista

2009-06-08 03:52 (#341) - ObjectListView/ObjectListView.cs
  - Fixed rare bug in UnapplyHotItemStyle()

2009-06-08 03:51 (#340) - ObjectListView/ObjectListView2008.csproj
  - Turned off TRACE

2009-06-08 03:51 (#339) - ObjectListView/ToolTipControl.cs
  - Fixed some Vista specific problems

2009-06-08 03:50 (#338) - ObjectListView/NativeMethods.cs
  - Added ChangeSize() method

2009-06-08 03:50 (#337) - ObjectListView/Renderers.cs
  - Tweaked text rendering so that column 0 isn't ellipsed unnecessarily.

2009-06-06 00:57 (#336) - ObjectListView/NativeMethods.cs, ObjectListView/ObjectListView.cs, ObjectListView/GlassPanelForm.cs
  - Overlays and tooltips now work when the OLV is on a TopMost form

2009-06-04 01:29 (#335) - docs/features.rst, docs/whatsnew.rst, docs/blog.rst, docs/conf.py, docs/recipes.rst, docs/.templates/layout.html, docs/overlays.rst, docs/changelog.rst
  - v2.2 documentations ready

2009-06-04 01:27 (#334) - Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - v2.2 ready

2009-06-04 01:26 (#333) - ObjectListView/ObjectListView.cs
  - BeforeSortingEventArgs now has a Handled property to let event handlers do the item sorting themselves.
  - Exposed CellToolTip and HeaderToolTip, and related events
  - AlwaysGroupByColumn works again, as does SortGroupItemsByPrimaryColumn and all their various permutations.
  - SecondarySortOrder and SecondarySortColumn are now "null" by default
  - Fixed bug so that KeyPress events are again triggered

2009-06-04 01:20 (#332) - ObjectListView/Renderers.cs
  - Removed obsolete FlagRenderer<T> class

2009-06-04 01:20 (#331) - ObjectListView/Overlays.cs
  - Make sure that TintedColumnDecoration reaches to the last item in group view

2009-06-04 01:19 (#330) - ObjectListView/VirtualObjectListView.cs
  - BuildList() now updates virtual list size

2009-06-04 01:19 (#329) - ObjectListView/NativeMethods.cs
  - Added methods to support custom tooltips

2009-06-04 01:18 (#328) - ObjectListView/ObjectListView2008.csproj, ObjectListView/ObjectListView.csproj
  - Added ToolTipControl.cs

2009-06-04 01:17 (#327) - ObjectListView/HeaderControl.cs
  - Changed to use ToolTipControl

2009-06-04 01:16 (#326) - ObjectListView/Events.cs
  - Added ColumnToGroupBy and GroupByOrder to sorting events
  - Gave all event descriptions
  - Added tool tip events

2009-06-04 01:15 (#325) - ObjectListView/DropSink.cs
  - Added a Handled flag to OlvDropEventArgs
  - Tweaked the appearance of the drop-on-background feedback

2009-06-04 01:13 (#323) - ObjectListView/Comparers.cs
  - Fixed bug where ModelObjectComparer would crash if secondary sort column was null.



v2.2 beta - 15 May 2009
-----------------------

2009-05-15 22:42 (#322) - ObjectListView/GlassPanelForm.Designer.cs, ObjectListView/GlassPanelForm.resx, ObjectListView/ObjectListView2008.csproj, ObjectListView/ObjectListView.cs, ObjectListView/GlassPanelForm.cs
  - Simplified GlassPanelForm
  - Add subitems to custom draw

2009-05-15 22:40 (#321) - Demo/MainForm.cs, Demo/MainForm.Designer.cs
  - Fixed problem with attribute renderer

2009-05-13 06:14 (#320) - docs/whatsnew.rst, docs/index.rst, docs/blog.rst, docs/.static/download-icon.png, docs/.templates/layout.html, docs/download.rst, docs/overlays.rst, docs/changelog.rst
  - v2.2 documentation - Take II

2009-05-13 06:13 (#319) - Tests/TestTreeView.cs, Tests/Program.cs
  - Added tests for tree traversal
  - Use DiscardAllState() between tests

2009-05-13 06:12 (#318) - Demo/MainForm.cs, Demo/MainForm.Designer.cs
  - "Remove" button on Simple tab now removes all selected objects

2009-05-13 06:11 (#317) - ObjectListView/TreeListView.cs
  - Added tree traverse operations: GetParent and GetChildren.
  - Added DiscardAllState() to completely reset the TreeListView.

2009-05-11 06:45 (#316) - ObjectListView/HeaderControl.cs, ObjectListView/TreeListView.cs, ObjectListView/ObjectListView2008.csproj, ObjectListView/ObjectListView.cs
  - Removed all unsafe code. The project now compiles without requiring unsafe code.

2009-05-10 01:57 (#314) - ObjectListView/ObjectListView.cs
  - Added SelectColumnTint property
  - Refactored some initialize code

2009-05-10 01:56 (#313) - ObjectListView/Overlays.cs
  - Updated docs

2009-05-10 01:55 (#312) - ObjectListView/TreeListView.cs
  - Fixed bug where any command (Expand/Collapse/Refresh) on a model object that was once visible but that is currently in a collapsed branch would cause the control to crash.

2009-05-10 01:54 (#311) - Tests/TestTreeView.cs, Tests/Person.cs, Tests/Program.cs
  - Added more tests for TreeListView

2009-05-10 01:52 (#310) - Demo/MainForm.cs, Demo/MainForm.Designer.cs
  - Added Refresh button to TreeList tab

2009-05-09 08:25 (#309) - ObjectListView/ObjectListView.cs
  - Use SmallImageSize when possible

2009-05-09 08:24 (#308) - ObjectListView/Renderers.cs
  - Use SmallImageSize when possible

2009-05-09 08:23 (#307) - ObjectListView/DropSink.cs
  - Updated docs

2009-05-09 08:23 (#306) - ObjectListView/TreeListView.cs
  - Fixed bug where RefreshObjects() would fail when none of the given objects were present/visible.

2009-05-08 07:12 (#305) - docs/index.rst, docs/conf.py, docs/recipes.rst, docs/images/overlay.png, docs/.templates/layout.html, docs/overlays.rst, docs/changelog.rst
  - Added some more overlays docs

2009-05-08 07:09 (#304) - ObjectListView/HeaderControl.cs, ObjectListView/NativeMethods.cs, ObjectListView/ObjectListView.cs, ObjectListView/GlassPanelForm.cs
  - Don't use glass panel for overlays in Design Mode

2009-05-07 00:33 (#303) - docs/images/dragdrop-example1.png, docs/images/dragdrop-feedbackcolor.png, docs/images/ClassDiagram.png, docs/.static/dragdrop-icon.png, docs/images/dragdrop-dropbetween.png, docs/blog.rst, docs/images/blog-setbkimage.png, docs/recipes.rst, docs/.templates/layout.html, docs/images/dragdrop-dropsubitem.png, docs/images/dragdrop-infomsg.png, docs/changelog.rst, docs/images/emptylistmsg-example.png, docs/whatsnew.rst, docs/images/blog-overlayimage.png, docs/index.rst, docs/.static/blog-icon.png, docs/dragdrop.rst, docs/images/ClassDiagram-VirtualList.png, docs/conf.py, docs/images/dragdrop-dropbackground.png, docs/images/blog-badscroll.png
  - v2.2 documentation - Take I

2009-05-07 00:27 (#302) - Demo/MainForm.cs, Demo/ObjectListViewDemo.csproj, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Added Nag level combo box to Virtual tab, so show various possibilities with text overlays

2009-05-07 00:25 (#301) - ObjectListView/ObjectListView.csproj
  - Added GlassPanelForm to project

2009-05-07 00:24 (#300) - ObjectListView/ObjectListView.cs
  - Changed the implementation of overlays to always use GlassPanelForm, rather than a hybrid
  - Added Scroll event and Unfocused foreground and background colors (thanks to Christophe Hosten)
  - Added Decorations (scrolling overlays)
  - Added SelectedColumn property, which puts a slight tint on that column. Combine this with TintSortColumn property and the sort column is automatically tinted.
  - Use an overlay to implement "empty list" msg. Default empty list msg is now prettier.
  - Consistently use LastSortColumn and LastSortOrder properties instead of using the private fields.

2009-05-07 00:19 (#299) - ObjectListView/Renderers.cs
  - Added Unfocused foreground and background colors (thanks to Christophe Hosten)

2009-05-07 00:19 (#298) - ObjectListView/NativeMethods.cs
  - Added GetColumnSides()
  - Added scroll stuff
  - Added  SetSelectedColumn() [even though it's useless!]

2009-05-07 00:17 (#297) - ObjectListView/GlassPanelForm.cs
  - Changed to always use glass overlay
  - Updated code layout and docs

2009-05-07 00:15 (#296) - ObjectListView/Events.cs
  - Added Scroll event

2009-05-07 00:14 (#295) - ObjectListView/Overlays.cs
  - Unified BillboardOverlay text rendering with that of TextOverlay
  - Improved docs
  - Removed transparency parameter from IOverlay interface
  - Added Rotation to Overlays
  - Added SelectedColumnOverlay

2009-05-07 00:01 (#294) - ObjectListView/DropSink.cs
  - Removed transparency parameter from IOverlay interface

2009-04-29 08:29 (#293) - ObjectListView/Overlays.cs, ObjectListView/NativeMethods.cs, ObjectListView/GlassPanelForm.Designer.cs, ObjectListView/GlassPanelForm.resx, ObjectListView/ObjectListView2008.csproj, ObjectListView/Events.cs, ObjectListView/ObjectListView.cs, ObjectListView/GlassPanelForm.cs
  - Use GlassPanelForm to show overlays when scrolling
  - Correctly refresh overlays when marque selecting
  - Fixed bug where DoubleClick events were not triggered when CheckBoxes was true
  - Overlays can no longer have individual transparency
  - Moved bordering and backgrounding from BillboardOverylay to TextOverlay

2009-04-29 08:27 (#292) - ObjectListView/DropSink.cs
  - Allow CanDrop event handlers to change DropTarget*

2009-04-24 05:13 (#291) - Demo/Resources/redbull.png, Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Updated demo for v2.2a - take 2
  - Added missing redbull image

2009-04-24 05:12 (#290) - ObjectListView/Overlays.cs, ObjectListView/Renderers.cs
  - Changed to use "Appearance - ObjectListView" category

2009-04-24 05:11 (#289) - ObjectListView/ObjectListView.cs
  - Fixed various bugs under Vista.
  - Made groups collapsible - Vista only. Thanks to Crustyapplesniffer.
  - Forward events from DropSink to the control itself. This allows handlers to be defined within the IDE for drop events
  - Added ObjectListView.IsVista

2009-04-24 05:10 (#288) - ObjectListView/NativeMethods.cs
  - Added GROUP structures

2009-04-24 05:10 (#287) - ObjectListView/Events.cs
  - Added some documentation strings

2009-04-24 05:09 (#286) - ObjectListView/DropSink.cs
  - Simplified RearrangingDropSink

2009-04-24 05:08 (#285) - ObjectListView/DragSource.cs
  - Renamed *DataSource to *DragSource, as it always should have been

2009-04-22 00:42 (#284) - Demo/Resources/limeleaf.png, Demo/Resource1.Designer.cs, Demo/MainForm.cs, Demo/Properties, Demo/Resources/redback1.png, Demo/ObjectListViewDemo2008.csproj, Demo/MainForm.Designer.cs, Demo/MainForm.resx, Demo/Resource1.resx
  - Updated for v2.2a

2009-04-22 00:38 (#283) - ObjectListView/Properties/AssemblyInfo.cs
  - Updated version to 2.2a

2009-04-22 00:37 (#282) - ObjectListView/TypedObjectListView.cs
  - Added Objects property

2009-04-22 00:34 (#280) - ObjectListView/TreeListView.cs
  - Fixed SF#2499313 - Calling Expand() on an already expand branch causes a confused display of the branches children
  - Calculate edit rectangle on column 0 more accurately

2009-04-22 00:33 (#279) - ObjectListView/ObjectListView2008.csproj, ObjectListView/ObjectListView.csproj
  - Added new files for v2.2

2009-04-22 00:31 (#278) - ObjectListView/ObjectListView.cs
  - Reorganized code ready for v2.2alpha release
  - Implemented overlay architecture, based on CustomDraw scheme. This unified drag drop feedback, empty list msgs and overlay images.
  - Added OverlayImage and OverlayText to allow transparent images and text over the listview from within the IDE
  - Fixed long-standing annoying flicker on owner drawn virtual lists! This means, amongst other things, that grid lines no longer get confused, and drag-select no longer flickers.
  - Made several properties localizable.
  - Correctly renderer checkboxes when RowHeight is non-standard
  - Added RowHeightEffective property
  - Added MoveObjects()
  - Update row colors after RemoveObject()
  - Calculate edit rectangles more accurately
  - Maintain focused item when rebuilding list (SF #2547060)

2009-04-22 00:28 (#277) - ObjectListView/NativeMethods.cs
  - Added structure and methods to put image under ListView (no longer used)
  - Added custom draw structures

2009-04-22 00:26 (#276) - ObjectListView/DragSource.cs, ObjectListView/Overlays.cs, ObjectListView/DropSink.cs
  - Initial checkin for version 2.2

2009-04-22 00:23 (#275) - ObjectListView/Renderers.cs
  - Fixed off-by-1 error when calculating text widths. This caused middle and right aligned columns to always wrap one character when printed using ListViewPrinter (SF#2776634).
  - Correctly renderer checkboxes when RowHeight is non-standard
  - Allow for item indent when calculating edit rectangle

2009-04-07 08:03 (#274) - ObjectListView/VirtualObjectListView.cs
  - ClearObjects() now works again

2009-04-07 06:37 (#273) - ObjectListView/ObjectListView.cs
  - Double-clicking no longer toggles the checkbox
  - Double-clicking on a checkbox no longer confuses the checkbox
  - Optimized the build of autocomplete lists



v2.1 - 26 February 2009
-----------------------

2009-02-26 17:44 (#272) - docs/features.rst, docs/whatsnew.rst, docs/cellEditing.rst, docs/ClassDiagram-VirtualList.dia, docs/ClassDiagram.dia, docs/faq.rst, docs/changelog.rst, docs/gettingStarted.rst
  - Updated feature list
  - Added clas diagrams

2009-02-26 17:41 (#271) - Tests/TestCheckBoxes.cs, Tests/Program.cs
  - Updated tests to allow for events on virtual lists

2009-02-26 17:41 (#270) - ListViewPrinter/ListViewPrinter.cs
  - Correctly use new renderer scheme :)

2009-02-26 17:40 (#269) - Demo/MainForm.cs, Demo/MainForm.Designer.cs
  - Removed redundant code

2009-02-26 17:39 (#268) - ObjectListView/ObjectListView.cs
  - Maintain focused item when rebuilding list (SF #2547060)
  - Fix bug where double-clicking VERY quickly on two different cells could give two editors
  - Removed HitTestDelegate and co since that was only ever an experiment

2009-02-26 17:37 (#267) - ObjectListView/TreeListView.cs
  - All TreeListView commands now work when the list is empty
  - TreeListViews can now be printed

2009-02-26 17:35 (#266) - ObjectListView/VirtualObjectListView.cs
  - ItemCheck and ItemChecked events now work on virtual lists
  - Removed redundant OnMouseDown() since checkbox handling is now handled in the base class

2009-02-26 17:33 (#265) - ObjectListView/Renderers.cs
  - Renderers now work properly with ListViewPrinter

2009-02-26 17:32 (#264) - ObjectListView/FastObjectListView.cs
  - Minor documentation update

2009-02-24 07:20 (#263) - docs/index.rst
  - Added more nice references

2009-02-24 07:17 (#261) - ObjectListView/ObjectListView2008.csproj
  - Changed require .Net version back to 2.0 (instead of 3.5)

2009-02-24 07:16 (#260) - ObjectListView/Properties/AssemblyInfo.cs
  - Changed version number

2009-02-24 07:15 (#259) - ObjectListView/ObjectListView.cs
  - Reworked checkboxes so that events are triggered for virtual lists
  - ToggleCheckObject() now handle TriStateCheckBoxes
  - Removed some commented out code
  - Added ObjectListView.ConfigureAutoComplete utility method
  - Added RowsPerPage property
  - Optimized native windows message handling
  - Added IsSelected()

2009-02-24 07:13 (#258) - ObjectListView/Munger.cs
  - Made Munger a public class



v2.1a - 07 February 2009
------------------------

2009-02-03 09:28 (#257) - ObjectListView/ObjectListView.cs
  - Fixed bug with AlwaysGroupByColumn where column header clicks would not resort groups.

2009-02-03 09:27 (#256) - docs/whatsnew.rst, docs/faq.rst, docs/.templates/layout.html, docs/changelog.rst
  - Updated fixed bug descriptions
  - Generated change log
  - Fixed links to download and discussion in template

2009-02-03 09:26 (#255) - Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Simple tab "Lock group" now locks sort order too

2009-02-02 09:35 (#254) - docs/.static/listCtrlPrinter-icon.png, docs/images/gettingstarted-example6.png, docs/images/right-arrow.gif, docs/.static/icon.ico, docs/.static/dialog2-blue-800x1600.png, docs/recipes.rst, docs/.static/majorClasses-icon.png, docs/.templates, docs/images/orange-800x1600.png, docs/.static/structure.css, docs/.static/Thumbs.db, docs/.static/gettingStarted-icon.png, docs/.static/groupListView-icon.png, docs/images/treelistview.png, docs/images/dark-blue-800x1600.png, docs/majorClasses.rst, docs/images/gettingstarted-example3.png, docs/.static/features-icon.png, docs/images/redbull.jpg, docs/.static/whatsnew-icon.png, docs/images/tileview-example.png, docs/.static/search-icon.png, docs/listCtrlPrinter.rst, docs/images/ownerdrawn-example1.png, docs/images/dialog2-blue.gif, docs/images/limeleaf.jpg, docs, docs/images/right-arrow.png, docs/images/image-renderer.png, docs/faq.rst, docs/whatsnew.rst, docs/ownerDraw.rst, docs/images/flags-renderer.png, docs/images/images-renderer.png, docs/index.rst, docs/.static/initial.css, docs/images/light-blue-800x1600.png, docs/.static, docs/.static/global.css, docs/images/ModelToScreenProcess.png, docs/images/gettingstarted-example4.png, docs/images/ReportModernExample.jpg, docs/images/mappedimage-renderer.png, docs/.static/master.css, docs/images/fancy-screenshot.png, docs/images/multiimage-renderer.png, docs/.static/recipes-icon.png, docs/images/tileview-ownerdrawn.png, docs/.static/faq-icon.png, docs/.static/cellEditing-icon.png, docs/images/icecream3.jpg, docs/.templates/layout.html, docs/images/bar-renderer.png, docs/.static/reset.css, docs/changelog.rst, docs/features.rst, docs/.static/changelog-icon.png, docs/images/printpreview.png, docs/.static/dialog.css, docs/.static/index-icon.png, docs/images/gettingstarted-example1.png, docs/.static/orange-800x1600.png, docs/images/gettingstarted-example5.png, docs/images, docs/images/smoothie2.jpg, docs/.static/dark-blue-800x1600.png, docs/images/coffee.jpg, docs/gettingStarted.rst, docs/cellEditing.rst, docs/images/ObjectListView.jpg, docs/.static/light-blue-800x1600.png, docs/images/dialog2-blue-800x1600.png, docs/conf.py, docs/.static/ownerDraw-icon.png, docs/images/gettingstarted-example2.png
  - New style docs using Sphinx system

2009-02-02 09:11 (#253) - ListViewPrinter/ListViewPrinter2008.csproj, ObjectListView/ObjectListView2008.csproj, ListViewPrinterDemo/ListViewPrinterDemo2008.csproj, Demo/ObjectListViewDemo2008.csproj, ObjectListView2008.sln, Tests/Tests2008.csproj
  - Added VS2008 solution and projects

2009-02-02 09:09 (#252) - ObjectListView/ObjectListView.csproj
  - Renderers are now Components

2009-02-02 09:07 (#251) - ListViewPrinter/ListViewPrinter.cs
  - Use new renderer scheme
  - Removed ugly hack about BarRenderer when printing.

2009-02-02 09:06 (#250) - Tests/TestCheckBoxes.cs
  - Update to include subitem checkboxes tests

2009-02-02 09:06 (#249) - Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Updated to match v2.1 alpha

2009-02-02 09:05 (#248) - ObjectListView/Properties/AssemblyInfo.cs
  - Changed version number

2009-02-02 09:04 (#247) - ObjectListView/TreeListView.cs
  - Changed to use new Renderer and HitTest scheme
  - Added RevealAfterExpand property. If this is true (the default) after expanding a branch, the control scrolls to reveal as much of the expanded branch as possible.

2009-02-02 09:04 (#246) - ObjectListView/Renderers.cs
  - Major overhaul of renderers. Now uses IRenderer interface.
  - ImagesRenderer and FlagsRenderer<T> are now defunct. The names are retained for backward compatibility.
  - Align bitmap AND text according to column alignment (previously only text was aligned and bitmap was always to the left).
  - Changed to use TextRenderer rather than native GDI routines.
  - Added CheckStateRenderer
  - Added BaseRenderer.DrawImages()
  - Reorganized methods in Renderers.cs

2009-02-02 09:01 (#245) - ObjectListView/NativeMethods.cs
  - Added GetCountPerPage()
  - Removed GDI methods that were added in last revision

2009-02-02 09:00 (#244) - ObjectListView/ObjectListView.cs
  - Added UseSubItemCheckBoxes to initialize checkbox images
  - OLVColumn.CheckBoxes and TriStateCheckBoxes now work.
  - Changed CalculateCellBounds to correctly calculate bounds of column 0 cells
  - Use renderer to calculate cell editor bounds
  - Finished HitTest portion of new renderer scheme
  - Added ObjectListView.ItemRenderer to draw whole items (rather than double dutying the renderer of column 0)
  - Handle owner drawn of non-Details views
  - Simple Checkboxes now work properly
  - Added TriStateCheckBoxes property to control whether the user can set the row checkbox to have the Indeterminate value
  - CheckState property is now just a wrapper around the StateImageIndex property

2009-02-02 08:56 (#243) - ObjectListView/DataListView.cs
  - Boolean columns are now handled as checkboxes
  - Auto-generated columns would fail if the data source was reseated, even to the same data source

2009-01-21 09:39 (#242) - Tests/TestColumn.cs
  - Added new test for Munger being used to indexer access

2009-01-21 09:38 (#241) - Demo/Persons.xml, Demo/Resource1.Designer.cs, Demo/MainForm.cs, Demo/ObjectListViewDemo.csproj, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Updated demo to show some new features

2009-01-21 09:36 (#240) - Demo/ShellUtilities.cs
  - Removed an overzealous assert

2009-01-21 09:36 (#239) - ObjectListView/Renderers.cs
  - Changed draw from image list if possible. 30% faster!
  - Tweaked some spacings to look more like native ListView
  - Text highlight for non FullRowSelect is now the right color when the control doesn't have focus.
  - Commented out experimental animations. Still needs work.

2009-01-21 09:35 (#238) - ObjectListView/ObjectListView.cs
  - Changed to always draw columns when owner drawn, rather than falling back on DrawDefault. This simplified several owner drawn problems
  - Added DefaultRenderer property to help with the above
  - HotItem background color is applied to all cells even when FullRowSelect is false
  - Allow grouping by CheckedAspectName columns
  - Commented out experimental animations. Still needs work.

2009-01-21 09:32 (#237) - ObjectListView/Munger.cs
  - Made the Munger capable of handling indexed access. Incidentally, this removed the ugliness that the last change introduced.

2009-01-20 09:16 (#236) - ListViewPrinter/ListViewPrinter.cs
  - Use IsPrinting property on BaseRenderer

2009-01-20 09:15 (#235) - ObjectListView/Properties/AssemblyInfo.cs
  - Changed version number

2009-01-20 09:14 (#234) - ObjectListView/VirtualObjectListView.cs
  - Support hot item tracking

2009-01-20 09:13 (#233) - ObjectListView/TreeListView.cs
  - HandleLButtonDown() was moved to base class so we now override it

2009-01-20 09:12 (#232) - ObjectListView/Renderers.cs
  - Changed to draw text using GDI routines. Looks more like native control this way. Set UseGdiTextRendering to false to revert to previous behavior.
  - Added IsPrinting property
  - IsDrawBackground is now calculated and cannot be set
  - Draw background correctly when control is disabled
  - Render checkboxes using CheckBoxRenderer

2009-01-20 09:09 (#231) - ObjectListView/ObjectListView.cs
  - Added checkboxes on subitems
  - Added HotItemStyle and UseHotItem to highlight the row under the cursor
  - Added UseCustomSelectionColors property
  - Owner draw mode now honors ForeColor and BackColor settings on the list
  - Changed to use EditorRegistry
  - Changed to use Equals() method rather than == to compare model objects.

2009-01-20 09:07 (#230) - ObjectListView/NativeMethods.cs
  - Added method need to draw text using GDI routines

2009-01-20 09:07 (#229) - ObjectListView/Munger.cs
  - Handle target objects from a DataListView (normally DataRowViews) [This is really ugly and NEEDS to be changed)

2009-01-20 09:06 (#228) - ObjectListView/Events.cs
  - Moved SelectionChanged event to this file

2009-01-20 09:06 (#227) - ObjectListView/DataListView.cs
  - Boolean columns are now handled as checkboxes
  - Auto-generated columns would fail if the data source was reseated, even to the same data source

2009-01-20 09:05 (#226) - ObjectListView/CellEditors.cs
  - Added special handling for enums
  - Changed to use EditorRegistry

2009-01-16 01:17 (#225) - ObjectListView/ObjectListView.cs
  - FinishCellEditing can now be safely called when no cell is being edited

2009-01-16 01:16 (#224) - ObjectListView/TreeListView.cs
  - Changed TreeRenderer to work with visual styles are disabled



v2.0.1 - 10 January 2009
------------------------

2009-01-09 18:33 (#223) - Demo/Persons.xml, Demo/MainForm.cs, Demo/ObjectListViewDemo.csproj, Demo/MainForm.Designer.cs
  - Handle right click on complex list to show EnsureGroupVisible() in action
  - Made Name column on Data tab wrap its text rather than ellipse it
  - Added comment about how to use LinePen for a TreeRenderer

2009-01-09 18:29 (#222) - ObjectListView/NativeMethods.cs
  - Added Scroll() method

2009-01-09 18:29 (#221) - ObjectListView/TreeListView.cs
  - Made all public and protected methods virtual
  - Changed some classes from 'internal' to 'protected' so that they can be accessed by subclasses of TreeListView.

2009-01-09 18:28 (#220) - ObjectListView/Renderers.cs
  - Removed incorrect documentation on the CanWrap property. Renderers honour this setting in all contexts

2009-01-09 18:27 (#219) - ObjectListView/TypedObjectListView.cs
  - Made all public and protected methods virtual

2009-01-09 18:27 (#218) - ObjectListView/VirtualObjectListView.cs
  - Made all public and protected methods virtual

2009-01-09 18:26 (#217) - ObjectListView/FastObjectListView.cs
  - Made all public and protected methods virtual

2009-01-09 18:26 (#216) - ObjectListView/DataListView.cs
  - Made all public and protected methods virtual

2009-01-09 18:24 (#215) - ObjectListView/ObjectListView.cs
  - Fixed long-standing "multiple columns generated" problem. Thanks to pinkjones for his help with solving this one!
  - Added EnsureGroupVisible()
  - Made all public and protected methods virtual
  - PossibleFinishCellEditing and CancelCellEditing are now public
  - Added Description for RowHeight property

2009-01-04 01:14 (#214) - Demo/MainForm.cs
  - Give an example of how to chain the line pen of a tree renderer

2009-01-04 01:13 (#213) - ObjectListView/TreeListView.cs
  - Added UseWaitCursorWhenExpanding property
  - Made TreeRenderer public so that it can be subclassed
  - Added LinePen property to TreeRenderer to allow the connection drawing pen to be changed
  - Fixed some rendering issues where the text highlight rect was miscalculated
  - Fixed connection line problem when there is only a single root

2009-01-04 01:11 (#212) - ObjectListView/Renderers.cs
  - Render text correctly when HideSelection is true.
  - BaseRenderer now works correctly in all Views
  - Fixed two small bugs in BarRenderer

2009-01-04 01:10 (#211) - ObjectListView/ObjectListView.cs
  - Added Description for RowHeight property

2008-12-21 09:25 (#210) - ObjectListView/Comparers.cs
  - Fixed bug with group comparisons when a group key was null (SF#2445761)

2008-12-21 09:18 (#209) - ObjectListView/ObjectListView.cs
  - Fixed bug with group comparisons when a group key was null (SF#2445761)

2008-12-20 09:03 (#208) - ListViewPrinter/BrushPenData.cs, ListViewPrinter/ListViewPrinter.cs
  - Hide all obsolete properties from the code generator
  - Correctly set the default value of colors to be Color.Empty

2008-12-20 09:03 (#207) - ObjectListView/ObjectListView.cs
  - Fixed bug with space filling columns and layout events
  - Fixed RowHeight so that it only changes the row height, not the width of the images.

2008-12-11 00:22 (#206) - Demo/MainForm.Designer.cs
  - Generated code no longer includes Color.Empty, since that is the default (as it always should have been, but wasn't)

2008-12-11 00:21 (#205) - Demo/MainForm.cs
  - Cleaned up TreeListView initialization

2008-12-11 00:20 (#204) - ObjectListView/TreeListView.cs
  - TreeListView now works even when it doesn't have a SmallImageList

2008-12-11 00:19 (#203) - ObjectListView/ObjectListView.cs
  - Handle Backspace key. Resets the seach-by-typing state without delay
  - Made some changes to the column collection editor to try and avoid the multiple column generation problem.
  - Column collection editor now shows the aspect name as well as the column name
  - Updated some documentation

2008-12-08 07:21 (#202) - Demo/MainForm.cs
  - Simplified initialization of simple list

2008-12-08 07:20 (#201) - ObjectListView/VirtualObjectListView.cs
  - Trigger Before/AfterSearching events

2008-12-08 07:19 (#200) - ObjectListView/TreeListView.cs
  - Search-by-typing now works

2008-12-08 07:18 (#199) - ObjectListView/ObjectListView.cs
  - Search-by-typing now works when showing groups
  - Added BeforeSearching and AfterSearching events which are triggered when the user types into the list.
  - Added secondary sort information to Before/AfterSorting events
  - Reorganized group sorting code. Now triggers Sorting events.
  - Added GetItemIndexInDisplayOrder()
  - Tweaked in the interaction of the column editor with the IDE so that we (normally) don't rely on a hack to find the owning ObjectListView
  - Changed all 'DefaultValue(typeof(Color), "Empty")' to 'DefaultValue(typeof(Color), "")' since the first does not given Color.Empty as I thought, but the second does.

2008-12-08 07:11 (#198) - ObjectListView/Munger.cs
  - Changed small comment

2008-12-08 07:11 (#197) - ObjectListView/Events.cs
  - Added BeforeSearching and AfterSearching events
  - Added secondary sort information to Before/AfterSorting events



v2.0 - 30 November 2008
-----------------------

2008-11-30 01:24 (#196) - ListViewPrinterDemo/Form1.cs, ListViewPrinterDemo/Form1.Designer.cs
  - Made compatible with ListViewPrinter v2.0

2008-11-30 01:23 (#195) - ListViewPrinter/Properties/AssemblyInfo.cs, ListViewPrinter/ListViewPrinter.csproj, ListViewPrinter/ListViewPrinter.cs
  - Changed license to GPL v3, to be consistent with ObjectListView.
  - Added more compatibility methods/Properties
  - Changed version number

2008-11-30 01:22 (#194) - Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Simplified Simple Tab by using CheckedAspectName
  - Added code that shows tooltips and custom selection colors

2008-11-30 01:21 (#193) - Tests/TestSorting.cs, Tests/TestColumn.cs, Tests/TestCheckBoxes.cs, Tests/Program.cs
  - Added tests for CheckedAspectName
  - Added tests for updating values via OLVColumn
  - Added tests for sorting events
  - Added tests for preserving selection

2008-11-30 01:12 (#192) - ObjectListView/Properties/AssemblyInfo.cs
  - Changed name of company slightly

2008-11-30 01:07 (#191) - ObjectListView/ObjectListView.FxCop
  - Fixed some more reported issues

2008-11-30 01:07 (#190) - ObjectListView/ObjectListView.csproj
  - Added new files

2008-11-30 01:06 (#189) - ObjectListView/VirtualObjectListView.cs
  - Preserve sort order when adding objects

2008-11-30 01:05 (#188) - ObjectListView/TypedObjectListView.cs
  - Added tool tip getting methods

2008-11-30 01:05 (#187) - ObjectListView/TreeListView.cs
  - Corrected calculation of expand/collapse icon (SF#2338819)
  - Fixed ugliness with dotted lines in renderer (SF#2332889)
  - Fixed problem with custom selection colors (SF#2338805)

2008-11-30 01:04 (#186) - ObjectListView/ObjectListView.cs
  - Added support for cell and header tool tips
  - Added CheckedAspectName to simplify CheckBox handling
  - Fixed long standing bug with horizontal scrollbar when shrinking the window (thanks to Bartosz Borowik)
  - Delay making the HeaderControl until after the ObjectListView is completely created
  - Broke Reflection mechanism into Munger class
  - Moved comparers to Comparers.cs
  - Fixed some more redundant casts [FXCOP]
  - In the IDE, all ObjectListView behaviours now appear in a "Behavior - ObjectListView" category,

2008-11-30 01:02 (#185) - ObjectListView/NativeMethods.cs
  - Added support for cell and header tool tips
  - Added WINDOWPOS
  - Remove several unused methods and corrected some return types [FXCOP]

2008-11-30 01:00 (#184) - ObjectListView/FastObjectListView.cs
  - Moved ModelObjectComparer to Comparers.cs file

2008-11-30 01:00 (#183) - ObjectListView/Events.cs
  - In the IDE, all ObjectListView behaviours now appear in a "Behavior - ObjectListView" category,

2008-11-30 00:59 (#182) - ObjectListView/HeaderControl.cs, ObjectListView/Comparers.cs, ObjectListView/Munger.cs
  - Initial checkin

2008-11-22 23:04 (#181) - Demo/MainForm.Designer.cs
  - Added Refresh Selected button to treeListView tab

2008-11-22 23:04 (#180) - Tests/TestSorting.cs, Tests/Person.cs, Tests/MainForm.Designer.cs, Tests/Program.cs, Tests/Tests.csproj
  - Added sorting tests

2008-11-22 23:03 (#179) - ObjectListView/VirtualObjectListView.cs
  - Moved  IsSearchOnSortColumn to base class
  - Unified search-by-typing with ObjectListView

2008-11-22 23:02 (#178) - ObjectListView/NativeMethods.cs
  - Added search-by-typing structures NMLVFINDITEM, LVFINDITEM

2008-11-22 23:02 (#177) - ObjectListView/Events.cs
  - Moved ColumnRightClick event to here

2008-11-22 23:01 (#176) - ObjectListView/ObjectListView.cs
  - Fixed bug where enabling grouping when there was not a sort column would not produce a grouped list. Grouping column now defaults to column 0.
  - Added ability to search by sort column to ObjectListView. Unified this with ability that was already in VirtualObjectListView
  - Objects property now always returns the objects of a control, even in virtual mode
  - Made ColumnComparer public so it can be used elsewhere

2008-11-20 09:06 (#175) - ObjectListView/ObjectListView.cs
  - Fixed bug in ChangeToFilteredColumns() where DisplayOrder was not always restored correctly

2008-11-20 09:05 (#174) - ObjectListView/TreeListView.cs
  - AddObjects() and RemoveObjects() now operate on the root collection
  - Expand/collapse now preserve the selection -- more or less :)
  - Overrode RefreshObjects() to rebuild the given objects and their children

2008-11-20 09:04 (#173) - ObjectListView/VirtualObjectListView.cs
  - Fixed some caching issues
  - Check upper bound on item index when selecting objects

2008-11-20 09:04 (#172) - ObjectListView.sln
  - Added Tests project to solution

2008-11-20 09:03 (#171) - Demo/MainForm.cs, Demo/MainForm.Designer.cs, Demo/MainForm.resx
  - Cleaned up TreeListView demo a little

2008-11-20 09:03 (#170) - Tests/TestTreeView.cs
  - Added test for preserving selection after expand/collapse

2008-11-19 10:01 (#169) - ListViewPrinterDemo/Form1.resx, ListViewPrinterDemo/Resources/compass16.png, ListViewPrinterDemo/Properties/AssemblyInfo.cs, ListViewPrinterDemo/ListViewPrinterDemo.csproj, Demo/Resource1.Designer.cs, ListViewPrinterDemo/Form1.cs, ListViewPrinterDemo/Properties/Resources.resx, ListViewPrinterDemo/Properties/Settings.Designer.cs, ListViewPrinterDemo/Form1.Designer.cs, Demo/ShellUtilities.cs, Demo/MainForm.resx, ListViewPrinterDemo/Properties/Settings.settings, ListViewPrinterDemo/Properties/Resources.Designer.cs, ListViewPrinterDemo/Persons.xml, ObjectListView.sln, ListViewPrinterDemo/Program.cs, ListViewPrinterDemo/Properties, ListViewPrinterDemo/Resources, Demo/MainForm.cs, Demo/ObjectListViewDemo.csproj, Demo/ColumnSelectionForm.cs, Demo/MainForm.Designer.cs
  - Changed to accomodate v2.0 changes

2008-11-19 09:54 (#168) - ObjectListView/ObjectListView.cs
  - BIG CHANGE: Fissioned this file into separate files for each component
  - Event argument blocks moved to directly within the namespace, rather than being nested inside ObjectListView class.
  - Removed OLVColumn.CellEditor since it was never used.
  - Marked OLVColumn.AspectGetterAutoGenerated as obsolete (it has not been used for several versions now).
  - SelectedObjects is now an IList, rather than an ArrayList. This allows it to accept generic list (eg List<File>).
  - Support indeterminate checkbox values.
  - [BREAKING CHANGE] CheckStateGetter/CheckStatePutter now use CheckState types only. BooleanCheckStateGetter and BooleanCheckStatePutter added to ease transition.
  - Added setFocus parameter to SelectObject(), which allows focus to be set at the same time as selecting.
  - Corrected bug with owner drawn lists where a column 0 with a renderer would draw at column 0 even if column 0 was dragged to another position.
  - Correctly handle space filling columns when columns are added/removed
  - Consistently use try..finally for BeginUpdate()/EndUpdate() pairs
  - If LastSortOrder is None when adding objects, don't force a resort.
  - In the right-click column select menu, columns are now sorted by display order, rather than alphabetically

2008-11-19 09:46 (#167) - ObjectListView/VirtualObjectListView.cs, ObjectListView/TreeListView.cs, ObjectListView/TypedObjectListView.cs, ObjectListView/ObjectListView.csproj
  - new versions for v2.0

2008-11-19 09:43 (#166) - ObjectListView/CustomDictionary.xml, ObjectListView/ObjectListView.shfb, ObjectListView/ObjectListView.FxCop
  - Added FxCop project and settings

2008-11-19 09:40 (#165) - ObjectListView/Properties/AssemblyInfo.cs, ObjectListView/CellEditors.cs, ObjectListView/NativeMethods.cs, ObjectListView/Properties, ObjectListView/DataListView.cs, ObjectListView/Events.cs, ObjectListView/Renderers.cs
  - Split out from ObjectListView.cs
  - Minor changes to calm down FxCop

2008-11-19 09:34 (#164) - Tests/SetupTestSuite.cs, Tests/TestSelection.cs, Tests/AssemblyInfo.cs, Tests/TestColumn.cs, Tests/OLVTests.nunit, Tests/TestTreeView.cs, Tests/Person.cs, Tests/MainForm.Designer.cs, Tests/TestCheckBoxes.cs, Tests/MainForm.cs, Tests/TestBasics.cs, Tests/Program.cs, Tests/MainForm.resx, Tests/Tests.csproj
  - Added tests

2008-11-19 08:36 (#163) - ListViewPrinter/BrushForm.Designer.cs, ListViewPrinter/BrushForm.resx, ListViewPrinter/Properties/AssemblyInfo.cs, ListViewPrinter/ListViewPrinter.csproj, ListViewPrinter/BrushPenData.cs, ListViewPrinter/Properties, ListViewPrinter/BrushForm.cs, ListViewPrinter/ListViewPrinter.cs, ListViewPrinter/BrushPen.DesignTime.cs
  - Changed the way the BlockFormats are edited within the IDE

2008-11-19 02:10 (#162) - ObjectListView/FastObjectListView.cs
  - Fissioned ObjectListView.cs into separate files
  - New manner of interacting with VirtualObjectListView

2008-11-19 00:19 (#161) - ObjectListView.sln, ObjectListViewDemo.sln
  - New project structure for v2.0

2008-11-19 00:14 (#160) - Resources, Demo/AnimatedGifs, Demo/Resources, AnimatedGifs, Demo/Photos, Photos
  - New project structure for v2.0

2008-11-18 23:54 (#159) - Demo/ColumnSelectionForm.Designer.cs, Demo/Persons.xml, Demo/AssemblyInfo.cs, ColumnSelectionForm.cs, AssemblyInfo.cs, Demo/Resource1.Designer.cs, Resource1.Designer.cs, MainForm.resx, ColumnSelectionForm.Designer.cs, Persons.xml, Demo/ShellUtilities.cs, Demo/MainForm.resx, MainForm.cs, MainForm.Designer.cs, ShellUtilities.cs, ColumnSelectionForm.resx, Demo/MainForm.cs, Demo/ColumnSelectionForm.resx, Demo/ObjectListViewDemo.csproj, ObjectListViewDemo.csproj, Resource1.resx, Demo/ColumnSelectionForm.cs, Demo/MainForm.Designer.cs, Demo/Resource1.resx
  - New project structure for v2.0

2008-11-18 23:33 (#158) - ObjectListView.cs, ObjectListView/ObjectListView.cs
  - New project structure for v2.0

2008-11-18 23:27 (#157) - ListViewPrinter.cs, ListViewPrinter/ListViewPrinter.cs
  - New project structure for v2.0

2008-11-18 23:23 (#156) - AnimatedGifRenderer.cs
  - Was never used

2008-11-18 23:20 (#155) - Tests
  - New project structure for v2.0

2008-11-18 23:17 (#154) - ListViewPrinterDemo
  - New project structure for v2.0

2008-11-18 23:14 (#153) - ListViewPrinter
  - New project structure for v2.0



v1.13 - 24 July 2008
--------------------

2008-07-24 01:45 (#83) - ObjectListView.cs
  - Fixed a bug involving GetItem() on virtual lists
  - Consistently use copy-on-write semantics with Add/RemoveObject methods

2008-07-11 16:40 (#73) - MainForm.Designer.cs, MainForm.resx, MainForm.cs
  - Added code for cell validating on complex tab

2008-07-11 16:38 (#72) - ObjectListView.cs
  - Enable validation on cell editors through a CellEditValidating event.
  - Added HeaderControl.Handle to allow OLV to be used within UserControls.
  - Added LastSortColumn and LastSortOrder properties
  - Made SORT_INDICATOR_UP_KEY and SORT_INDICATOR_DOWN_KEY public

2008-06-24 08:15 (#68) - MainForm.Designer.cs, MainForm.resx, MainForm.cs
  - Added examples of checkboxes
  - Added "Lock Groups" checkbox

2008-06-24 08:13 (#67) - ObjectListView.cs
  - Broke the more generally useful CopyObjectsToClipboard() method out of CopySelectionToClipboard()
  - Added AlwaysGroupByColumn and AlwaysGroupBySortOrder, which force the list view to always be grouped by a particular column.
  - Allow check boxes on FastObjectListViews
  - Added CheckedObject and CheckedObjects properties
  - Don't do our context menu processing when in design mode
  - Separate showing and building our context menu so that the building can be used externally

