require 'albacore'

namespace :build do
  desc 'compiles the project'
    
  csc :compile => :init do|csc|
     csc.compile FileList["src/**/*.cs"].exclude("src/**/AssemblyInfo.cs")
     csc.references configatron.all_references
     csc.output = File.join(configatron.artifacts_dir,"#{configatron.root_namespace}_test.dll")
     csc.target = :library
  end

  task :rebuild => ["clean","compile"]
end
