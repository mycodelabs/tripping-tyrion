namespace :specs do

  nunit :run => [:init, :expand_all_template_files, 'build:rebuild'] do |nunit|    

    configatron.all_references.each do|file|
      FileUtils.cp(file,configatron.artifacts_dir)

    end

    FileUtils.cp("#{configatron.app_dir}/App.config", "#{configatron.artifacts_dir}/#{configatron.root_namespace}_test.dll.config")

    nunit.command = "#{configatron.artifacts_dir}/nunit-console.exe "
    nunit.assemblies "#{configatron.artifacts_dir}/#{configatron.root_namespace}_test.dll"
  end

end
