% Plot network and generate statistics
edges = dlmread('edges.csv');
coordinates = dlmread('coordinates.csv');
edges(all(edges == 0, 2), :) = []; 
edges = arrayfun(@num2str, edges, 'UniformOutput', false);
Graph = graph(edges(:, 1), edges(:, 2));
Nodes = Graph.Nodes.Name;
AdjacencyMatrix = adjacency(Graph);
Degree = degree(Graph);
Distances = distances(Graph);
Network_Diameter = max(Distances);
Mean_Path_Length = mean(Network_Diameter(:));
Centrality_Degree = centrality(Graph, 'degree');
Centrality_Closeness = centrality(Graph, 'closeness');
Centrality_Betweenness = centrality(Graph, 'betweenness');
Centrality_PageRank = centrality(Graph, 'pagerank');
Centrality_EigenVector = centrality(Graph, 'eigenvector');
Laplacian = laplacian(Graph);
Incidence = incidence(Graph);
Stats = sortrows(table(Nodes, Centrality_Degree, Centrality_Closeness, Centrality_Betweenness, Centrality_PageRank, Centrality_EigenVector));
Stats.Properties.VariableNames = {'Node','Degree','Closeness','Betweenness', 'PageRank', 'Eigen Vector'};
f=plot(Graph);
saveas(f,'network.png');
savefig('network.fig')	
p=plot(Graph);
Graph.Nodes.NodeColors = Degree;
p.NodeCData = Graph.Nodes.NodeColors;
colorbar
saveas(p,'network2.png');
savefig('network2.fig');
save('statistics');
figure(3);
clf;
hold on;
w=plot(coordinates(:, 1), coordinates(:, 2), '.');
gplot(AdjacencyMatrix, coordinates);
hold off;
saveas(w,'network3.png');
savefig('network3.fig')	