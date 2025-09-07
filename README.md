# add-or-remove-nodes-unbound-mode-treeview-xamarin

This repository demonstrates how to add or remove nodes in unbound mode using the Xamarin.Forms SfTreeView control. It provides a sample implementation that shows how to programmatically manage the tree structure at runtime, enabling dynamic addition and removal of nodes without relying on data binding.

## Sample

### XAML
```xaml
<ContentPage.Behaviors>
        <behavior:Behavior/>
    </ContentPage.Behaviors>
    <ContentPage.Content>
        <StackLayout>
            <Grid HeightRequest="50" >
                <Button x:Name="addButton" Text="Add Node" />
                <Button x:Name="deleteButton" Text="Delete Node" Grid.Column="1"/>
            </Grid>
            <syncfusion:SfTreeView x:Name="treeView" NotificationSubscriptionMode="CollectionChange">
                <syncfusion:SfTreeView.Nodes>
                    <treeviewengine:TreeViewNode x:Name="australia" Content="Australia" >
                        <treeviewengine:TreeViewNode.ChildNodes>
                            <treeviewengine:TreeViewNode Content="New South Wales">
                                <treeviewengine:TreeViewNode.ChildNodes>
                                    <treeviewengine:TreeViewNode Content="Sydney"/>
                                    <treeviewengine:TreeViewNode Content="Canberra"/>
                                    <treeviewengine:TreeViewNode Content="Newcastle–Maitland"/>
                                </treeviewengine:TreeViewNode.ChildNodes>
                            </treeviewengine:TreeViewNode>
                            <treeviewengine:TreeViewNode Content="Victoria">
                                <treeviewengine:TreeViewNode.ChildNodes>
                                    <treeviewengine:TreeViewNode Content="Melbourne"/>
                                </treeviewengine:TreeViewNode.ChildNodes>
                            </treeviewengine:TreeViewNode>
                        </treeviewengine:TreeViewNode.ChildNodes>
                    </treeviewengine:TreeViewNode>                    
                </syncfusion:SfTreeView.Nodes>
            </syncfusion:SfTreeView>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>
```

### Behavior
```csharp
public class Behavior : Behavior<ContentPage>
{
    #region Call back

    private void AddButton_Clicked(object sender, EventArgs e)
    {
        var india = new TreeViewNode() { Content = "India" };
        var delhi = new TreeViewNode() { Content = "Delhi" };
        var newDelhi = new TreeViewNode() { Content = "New Delhi" };
        delhi.ChildNodes.Add(newDelhi);
        var tamilNadu = new TreeViewNode() { Content = "Tamil Nadu" };
        var chennai = new TreeViewNode() { Content = "Chennai" };
        india.ChildNodes.Add(delhi);
        india.ChildNodes.Add(tamilNadu);
        tamilNadu.ChildNodes.Add(chennai);

        TreeView.Nodes.Add(india);
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        TreeView.Nodes.RemoveAt(1);
    }

    #endregion
}
```

## Requirements to run the demo

To run the demo, refer to [System Requirements for Xamarin](https://help.syncfusion.com/xamarin/system-requirements)

## Troubleshooting
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
