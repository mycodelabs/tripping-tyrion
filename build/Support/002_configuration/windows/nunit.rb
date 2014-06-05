configs = 
{
  :specs =>
  {
    :runner_options => ["-x","example"],
    :assemblies => Dir.glob("#{configatron.artifacts_dir}/*tests.dll"),
    :dir => File.join(configatron.artifacts_dir,"specs"),
    :report_dir => File.join(configatron.artifacts_dir,"report"),
    :tools_folder => File.join(Dir.glob("packages/NUnit.Runners.*").first,"tools")
  }
}
configatron.configure_from_hash configs