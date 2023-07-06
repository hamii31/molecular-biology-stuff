namespace ProteinSequenceReader
{
    using System.Text;
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFilePath = @" "; // protein sequence source folder
            string outputFilePath = @" "; // output = amino acids synthesized + compressed codon sequence view

            ProteinSequence(inputFilePath, outputFilePath);
        }
        private static void ProteinSequence(string inputFilePath, string outputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    TextReader tr = File.OpenText(inputFilePath);

                    List<char> proteins = new List<char>();

                    foreach (var item in tr.ReadToEnd())
                    {
                        proteins.Add(item);
                    }

                    StringBuilder output = new StringBuilder();
                    StringBuilder compressedCodonOutput = new StringBuilder();

                    foreach (var item in proteins)
                    {
                        switch (item)
                        {
                            case 'M':
                                compressedCodonOutput.Append("ATG");
                                output.AppendLine("Methionine");
                                break;
                            case 'F':
                                compressedCodonOutput.Append("TTY");
                                output.AppendLine("Phenylalanine");
                                break;
                            case 'L':
                                compressedCodonOutput.Append("CTN");
                                output.AppendLine("Leucine");
                                break;
                            case 'I':
                                compressedCodonOutput.Append("ATH");
                                output.AppendLine("Isoleucine");
                                break;
                            case 'V':
                                compressedCodonOutput.Append("GTN");
                                output.AppendLine("Valine");
                                break;
                            case 'S':
                                compressedCodonOutput.Append("TCN");
                                output.AppendLine("Serine");
                                break;
                            case 'P':
                                compressedCodonOutput.Append("CCN");
                                output.AppendLine("Proline");
                                break;
                            case 'T':
                                compressedCodonOutput.Append("ACN");
                                output.AppendLine("Threonine");
                                break;
                            case 'A':
                                compressedCodonOutput.Append("GCN");
                                output.AppendLine("Alanine");
                                break;
                            case 'Y':
                                compressedCodonOutput.Append("TAY");
                                output.AppendLine("Tyrosine");
                                break;
                            case 'H':
                                compressedCodonOutput.Append("H");
                                output.AppendLine("Histidine");
                                break;
                            case 'Q':
                                compressedCodonOutput.Append("CAR");
                                output.AppendLine("Glutamine");
                                break;
                            case 'N':
                                compressedCodonOutput.Append("AAY");
                                output.AppendLine("Asparagine");
                                break;
                            case 'K':
                                compressedCodonOutput.Append("AAR");
                                output.AppendLine("Lysine");
                                break;
                            case 'D':
                                compressedCodonOutput.Append("GAY");
                                output.AppendLine("Aspartic Acid");
                                break;
                            case 'E':
                                compressedCodonOutput.Append("GAR");
                                output.AppendLine("Glutamic Acid");
                                break;
                            case 'C':
                                compressedCodonOutput.Append("TGY");
                                output.AppendLine("Cysteine");
                                break;
                            case 'W':
                                compressedCodonOutput.Append("TGG");
                                output.AppendLine("Tryptophan");
                                break;
                            case 'R':
                                compressedCodonOutput.Append("CGN");
                                output.AppendLine("Arginine");
                                break;
                            case 'G':
                                compressedCodonOutput.Append("GGN");
                                output.AppendLine("Glycine");
                                break;
                            default:
                                break;
                        }
                    }
                    writer.WriteLine("Amino acids synthesized: ");
                    writer.WriteLine(output.ToString());
                    writer.WriteLine("Compressed codon sequence");
                    writer.WriteLine(compressedCodonOutput.ToString());
                }
            }
        }
    }
}
